using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagemenApp.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return db.Students.Find(id);
        }

        public void Createstudent(Student student)
        {
            db.Students.Add(student);
        }

        public void UpdateStudent(Student newStudent)
        {
            db.Entry(newStudent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void DeleteStudent(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public Mark GetMarks(int id)
        {
            return db.Marks.FirstOrDefault(mark => mark.StudentId == id);
        }
    }
}
