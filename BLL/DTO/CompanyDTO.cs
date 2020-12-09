﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<EmployeeDTO> Employees { get; set; }
    }
}
