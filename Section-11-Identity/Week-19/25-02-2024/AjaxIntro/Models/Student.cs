﻿namespace AjaxIntro.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int StudentNumber { get; set; }
        public string? FirstName { get; set; }
        public string? Lastname { get; set; }
        public bool IsActive { get; set; } =true;
    }
}
