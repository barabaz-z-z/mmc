using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Mmc.Models;

namespace Mmc
{
    class DataManipulator
    {
        private const String XML_FILENAME = "Firm.xml";
        private MmcContext _context;
        private XNamespace _namespace;

        public DataManipulator()
        {
            _context = new MmcContext();
        }

        public Boolean InitDatabase()
        {
            var isInitialized = false;
            var document = LoadXML();

            if (document != null && 
                document.Root != null &&
                document.Root.Name.LocalName.Equals("FIRMDataSet"))
            {
                _namespace = document.Root.Name.NamespaceName;
                _context.Departments = LoadDepartments(document.Root);
                _context.Employees = LoadEmployees(document.Root);

                isInitialized = true;
            }

            return isInitialized;
        }

        public List<TreeNode> GetTreeDepartments()
        {
            var treeDepartments = new List<TreeNode>();

            var rootDepartments = _context.Departments.Where(d => d.ParentId == -1).ToList();
            var restDepartments = _context.Departments.Where(d => d.ParentId != -1).ToList();

            foreach (var root in rootDepartments)
            {
                treeDepartments.Add(CreateNode(root));
                AddChildNode(treeDepartments.Last(), root.Id, restDepartments);
            }

            return treeDepartments;
        }

        public List<Employee> GetEmployees(Int32 departmentId)
        {
            var employees = _context.Employees.Where(e => e.DepartmentId == departmentId).ToList();
            return employees;
        }
        
        private XDocument LoadXML()
        {
            try
            {
                if (File.Exists(XML_FILENAME))
                {
                    var rootDocument = XDocument.Load(XML_FILENAME);
                    return rootDocument;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    "Exception occurs while trying to open xml file: {0}", ex.Message);
            }

            return new XDocument();
        }

        private List<Department> LoadDepartments(XElement root)
        {
            try
            {
                var xDepartments = root.Elements(_namespace + "tblDeps");
                var departments = new List<Department>();

                if (xDepartments.Any())
                {
                    foreach (var xDepartment in xDepartments)
                    {
                        var xId = xDepartment.Element(_namespace + "nDepId");
                        var id = Convert.ToInt32(xId.Value);

                        var xCode = xDepartment.Element(_namespace+"cCode");
                        var code = xCode.Value;

                        var xName = xDepartment.Element(_namespace + "cName");
                        var name = xName.Value;

                        var xParentId = xDepartment.Element(_namespace + "nPrnDepId");
                        var parentId = -1;
                        if (xParentId != null)
                        {
                            parentId = Convert.ToInt32(xParentId.Value);
                        }

                        var department = new Department()
                                             {
                                                 Id = id,
                                                 ParentId = parentId,
                                                 Code = code,
                                                 Name = name,
                                                 ChildDepartment = new List<Department>()
                                             };

                        departments.Add(department);
                    }

                    foreach (var department in departments)
                    {
                        department.ChildDepartment = GetChildDepartments(department.Id, departments);
                    }
                }

                return departments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить из базы отделы.\r\n" + ex.Message, "Ошибка");
            }

            return new List<Department>();
        }

        private List<Employee> LoadEmployees(XElement root)
        {
            try
            {
                var xEmployees = root.Elements(_namespace + "tblEmps");
                var employees = new List<Employee>();

                if (xEmployees.Any())
                {
                    foreach (var xEmployee in xEmployees)
                    {
                        var xId = xEmployee.Element(_namespace + "nEmpId");
                        var id = Convert.ToInt32(xId.Value);

                        var xDepartmentId = xEmployee.Element(_namespace + "nDepId");
                        var departmentId = Convert.ToInt32(xDepartmentId.Value);

                        var xSurname = xEmployee.Element(_namespace + "cLastName");
                        var surname = xSurname.Value;

                        var xName = xEmployee.Element(_namespace + "cFirstName");
                        var name = xName.Value;

                        var xPatronymic = xEmployee.Element(_namespace + "cPatronymic");
                        var patronymic = xPatronymic.Value;

                        var employee = new Employee()
                                           {
                                               Id = id,
                                               DepartmentId = departmentId,
                                               Surname = surname,
                                               Name = name,
                                               Patronimyc = patronymic
                                           };

                        employees.Add(employee);
                    }
                }

                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить из базы сотрудников./r/n" + ex.Message, "Ошибка");
            }

            return new List<Employee>();
        }

        private List<Department> GetChildDepartments(Int32 parentId, List<Department> departments)
        {
            var childDepartments = departments.Where(d => d.ParentId == parentId).ToList();
            return childDepartments;
        }

        private void AddChildNode(TreeNode parentNode, Int32 parentId, List<Department> departments)
        {
            var childDepartments = departments.Where(d => d.ParentId == parentId).ToList();
            var restDepartments = departments.Where(d => d.ParentId != parentId).ToList();

            foreach (var department in childDepartments)
            {
                parentNode.Nodes.Add(CreateNode(department));
                AddChildNode(parentNode.LastNode, department.Id, restDepartments);
            }
        }

        private TreeNode CreateNode(Department department)
        {
            var nodeDepartment = new TreeNode(department.Name);
            nodeDepartment.Tag = department.Id;

            return nodeDepartment;
        }
    }
}
