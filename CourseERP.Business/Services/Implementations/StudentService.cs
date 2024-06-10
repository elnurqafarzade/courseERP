using CourseERP.Business.Services.Interfaces;
using CourseERP.Core.Models;
using CourseERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Business.Services.Implementations
{
    public class StudentService : IStudentService
    {
        public void Create(Student student)
        {
            CourseERPDatabase.Students.Add(student);

        }

        public Student GetStudent(int id)
        {
            var data = CourseERPDatabase.Students.Find(x => x.Id == id);
            if (data is null)
            {
                throw new NullReferenceException("Student not found!");
            }
            return data;
        }

        public List<Student> GetAll()
        {
            return CourseERPDatabase.Students;
        }

        public void Remove(int id)
        {
            var data = CourseERPDatabase.Students.Find(x => x.Id == id);
            if (data is null)
            {
                throw new NullReferenceException("Student not found");


            }
                CourseERPDatabase.Students.Remove(data);
        }
    }
}