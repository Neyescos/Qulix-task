using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_task.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronimic { get; set; }
        public string Position { get; set; }
        public DateTime DateOfComing { get; set; }
        public CompanyModel Company { get; set; }
    }
}
