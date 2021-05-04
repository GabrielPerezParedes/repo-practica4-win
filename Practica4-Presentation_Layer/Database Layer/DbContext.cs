using Database_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Database_Layer
{
    public class DbContext : IDbContext
    {
        //acceso a la base de datos
        //referencias a las tablas de la base de datos

        public List<Student> StudentTable { get; set; }

        public DbContext()
        {
            //leer del archivo de config el DBConnection string
            // Entity Framework y Core
            // Patron Repository
            StudentTable = new List<Student>()
            {
                new Student(){ Id = "Group-001", Name = "Gabriel Perez", AvailableSlots = 8},
                new Student(){ Id = "Group-002", Name = "David Abrego", AvailableSlots = 2},
                new Student(){ Id = "Group-003", Name = "Sebastian Prieto", AvailableSlots = 11}
            };
        }

        public List<Student> AddStudents(List<Student> students)
        {
            StudentTable.AddRange(students);
            return students;
        }
        public Student UpdateStudent(Student studentToUpdate)
        {
            Student foundStudent = StudentTable.Find(student => student.Name == studentToUpdate.Name);
            return foundStudent;
        }
        public Student DeletePerson(Student studentToDelete)
        {
            StudentTable.Remove(studentToDelete);
            return studentToDelete;
        }
        public List<Student> GetAll()
        {
            return StudentTable;
        }
    }
}
