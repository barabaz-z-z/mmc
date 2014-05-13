using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmc.Models
{
    class Employee
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }
        public String Surname { get; set; }
        public String Patronimyc { get; set; }
        public DateTime BirthDate { get; set; }

        public Int32 DepartmentId { get; set; }
    }
}
