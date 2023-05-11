using System;
using Back_first.Models;
using Microsoft.AspNetCore.Mvc;

namespace Back_first.Controllers
{
    public class StudentsController : Controller
    {
        private List<Student> _students = new List<Student>
            {
                new Student
                {
                    Id= 1,
                    Firstname = "Ali",
                    Lastname = "Mammadov",
                    Age = 18,
                },

                new Student
                {
                    Id= 2,
                    Firstname = "Huseyn",
                    Lastname = "Pasayev",
                    Age = 30,
                },

                new Student
                {
                    Id= 3,
                    Firstname = "Ugur",
                    Lastname = "Mammadli",
                    Age = 25,
                },
            };


        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = _students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}

