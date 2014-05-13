using System;
using System.Windows.Forms;

namespace Mmc
{
    public partial class uiMainForm : Form
    {
        private DataManipulator _manipulator;

        public uiMainForm()
        {
            InitializeComponent();
        }

        private void uiMainForm_Load(object sender, EventArgs e)
        {
            _manipulator = new DataManipulator();
            if (_manipulator.InitDatabase())
            {
                FillDepartments();
                SelectFirstNode();
            }
            else
            {
                MessageBox.Show(
                    "Не удалось инициализировать базу данных.\r\n Проверьте корректное расположение и содержание базы данных.",
                    "Ошибка");
            }
        }

        private void uiDepartmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (uiDepartmentTreeView.SelectedNode != null)
            {
                var departmentId = Convert.ToInt32(uiDepartmentTreeView.SelectedNode.Tag);

                FillEmployees(departmentId);
            }
        }

        private void FillDepartments()
        {
            var nodes = _manipulator.GetTreeDepartments().ToArray();
            uiDepartmentTreeView.Nodes.AddRange(nodes);
        }

        private void SelectFirstNode()
        {
            if (uiDepartmentTreeView.Nodes.Count > 0)
            {
                uiDepartmentTreeView.SelectedNode = uiDepartmentTreeView.Nodes[0];
            }
        }

        private void FillEmployees(Int32 departmentId)
        {
            var employees = _manipulator.GetEmployees(departmentId);
            uiEmployeeListView.Items.Clear();

            foreach (var employee in employees)
            {
                var item = new ListViewItem(employee.Surname + " " + employee.Name + " " + employee.Patronimyc);
                
                item.SubItems.Add(employee.BirthDate.Date.ToString("d MMMM yyyy"));
                item.Tag = employee.Id;

                uiEmployeeListView.Items.Add(item);
            }
        }

    }
}
