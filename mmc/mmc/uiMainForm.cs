using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mmc.Models;

namespace mmc
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
            _manipulator.InitDatabase();

            FillDepartments(_manipulator.Departments);
        }

        private void FillDepartments(List<Department> departments)
        {
            var nodes = _manipulator.GetTreeDepartments().ToArray();
            uiDepartmentTreeView.Nodes.AddRange(nodes);
        }

        private void FillEmployees(Int32 departmentId,List<Employee> employees)
        {
            var nodes = _manipulator.GetEmployees();
            uiEmployeeListView.Items.AddRange(nodes);
        }
    }
}
