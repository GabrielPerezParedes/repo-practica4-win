using Database_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database_Layer
{
    public interface IDbContext
    {
        List<Student> AddStudents(List<Student> student);

        Student UpdateStudent(Student studentToUpdate);

        Student DeletePerson(Student studentToDelete);

        List<Student> GetAll();
    }
}
