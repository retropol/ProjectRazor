﻿namespace ProjectRazor.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string PhotoPath { get; set; } = string.Empty;
    }
}
