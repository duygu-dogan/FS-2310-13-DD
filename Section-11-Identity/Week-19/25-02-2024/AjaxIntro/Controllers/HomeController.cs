﻿using AjaxIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxIntro.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
        [HttpPost]
        public IActionResult AddStudent(string firstName, string lastName, string studentNumber)
        {
            Student student = new Student
            {
                FirstName = firstName,
                Lastname = lastName,
                StudentNumber = Convert.ToInt32(studentNumber)
            };
            _context.Students.Add(student);
            _context.SaveChanges();
            List<Student> students = _context.Students.ToList();
            return PartialView("_StudentListPartial", students);
        }
        [HttpGet]
        public IActionResult ChangeIsActive(int id) {
            Student student = _context.Students.Find(id);
            student.IsActive = !student.IsActive;
            _context.SaveChanges();
            return Json(student.IsActive);
        }
    }
}
