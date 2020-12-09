using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDAL.Modules
{
    public class Employee:BaseEntity
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronimic { get; set; }
        public string Position { get; set; }
        public DateTime DateOfComing { get; set; }
        public Company Company { get; set; }


    }
}
