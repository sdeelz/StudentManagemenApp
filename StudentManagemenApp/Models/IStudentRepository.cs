using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagemenApp.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();

        Student GetStudentById(int id);

        void Createstudent(Student student);

        void DeleteStudent(int id);

        void UpdateStudent(Student newStudent);

        void Save();

        Mark GetMarks(int id);

    }
}
