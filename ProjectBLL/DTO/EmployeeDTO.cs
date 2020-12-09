using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronimic { get; set; }
        public string Position { get; set; }
        public DateTime DateOfComing { get; set; }
        public CompanyDTO Company { get; set; }

    }
}
