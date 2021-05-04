using Logic_Layer.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Logic_Layer.Models;

namespace Practica4_Presentation_Layer.Controllers
{
    [ApiController]
    [Route("[/api/students]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentManager _studentManager;
        public StudentsController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        // This Method Create a User
        [HttpPost]
        public List<Student> CreatePerson([FromBody] Student studentName) 
        {
            return _studentManager.CreatePerson(studentName);
        }

        // This Method Update a User
        [HttpPut]
        public Student UpdateStudent([FromBody] Student student)
        {
            return _studentManager.UpdateStudent(student);
        }

        // This Method Delete a User
        [HttpDelete]
        public Student DeletePerson([FromBody] Student student) 
        {
            return _studentManager.DeletePerson(student);
        }

        // This Method Get a User
        [HttpGet]
        public List<Student> GetStudents()
        {
            return _studentManager.GetAllStudents();
        }

    }
}
