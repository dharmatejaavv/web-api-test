﻿using System.ComponentModel.DataAnnotations;

namespace web_api_test.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Address { get; set; }

    }
}
