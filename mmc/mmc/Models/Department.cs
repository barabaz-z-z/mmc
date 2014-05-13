using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmc.Models
{
    class Department
    {
        public Int32 Id { get; set; }

        public String Code { get; set; }
        public String Name { get; set; }

        public Int32 ParentId { get; set; }
        public List<Department> ChildDepartment { get; set; }
    }
}
