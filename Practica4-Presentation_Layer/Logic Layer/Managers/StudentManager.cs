using System;
using System.Collections.Generic;
using System.Text;
using Logic_Layer.Models;
using Database_Layer;

namespace Logic_Layer.Managers
{
    public class StudentManager : IStudentManager
    {

        private readonly IDbContext _dbContext;
        public StudentManager(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Student> GetAllStudents()
        {
            List<Database_Layer.Models.Student> students = _dbContext.GetAll();
            // creamos el DTOMappers para evitar las ambiguedades
            return DTOMappers.MapStudents(students);
        }

        public List<Student> CreatePerson(Student student) // a. Create User
        {
            if (String.IsNullOrEmpty(student.Name) || student.Name.Length > 50 || student.AvailableSlots < 0) // Punto 6 practica 4
            {
                throw new Exception();
            }
            List<Database_Layer.Models.Student> studentDAO = DTOMappers.MapStudentsDAO(
                    new List<Student>() { student }
                );
            studentDAO = _dbContext.AddStudents(studentDAO);
            return DTOMappers.MapStudents(studentDAO);
        }

        public Student UpdateStudent(Student student) // b. Update User
        {
            student.Name = "updated";
            return student;
        }

        public Student DeletePerson(Student student) // c. Delete User
        {
            student.Name = "deleted";
            return student;
        }
    }
}
