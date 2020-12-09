using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Modules
{
    public class Company:BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
