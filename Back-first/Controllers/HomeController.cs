using System;
using Back_first.Models;
using Microsoft.AspNetCore.Mvc;

namespace Back_first.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
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

            return View(students);
        }
    }
}

