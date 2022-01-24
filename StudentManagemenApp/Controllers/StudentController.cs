using Microsoft.AspNetCore.Mvc;
using StudentManagemenApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagemenApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository _studentRepository)
        {
            this.studentRepository = _studentRepository;
        }

        public IActionResult Index()
        {
           var students = studentRepository.GetAllStudents();
           
           return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student newStudent)
        { 

            if (ModelState.IsValid)
            {
                Student student = new Student
                {
                    Name = newStudent.Name,
                    Email = newStudent.Email,
                    Age = newStudent.Age
                };

                studentRepository.Createstudent(student);
                studentRepository.Save();
            }

            return RedirectToAction("Index", "Student");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            
            var model = studentRepository.GetStudentById(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                var std = studentRepository.GetStudentById(newStudent.Id);

                if (std != null)
                {
                    std.Name = newStudent.Name;
                    std.Age = newStudent.Age;
                    std.Email = newStudent.Email;


                    studentRepository.UpdateStudent(std);
                    studentRepository.Save();

                }
            }

            return RedirectToAction("Index","Student");
        }

        [HttpGet]
        public IActionResult DisplayMarks(int id)
        {

                var student = studentRepository.GetStudentById(id);
                var marks = studentRepository.GetMarks(id);

               double total = (marks.Maths + marks.English + marks.Science);

                MarkDisplayViewModel model = new MarkDisplayViewModel
                {
                    student = student,
                    mark = marks,
                    TotalMarks = total
                };

            
            return View(model);
        }
    }
}
