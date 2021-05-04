using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Models
{
    public static class DTOMappers
    {
        public static List<Student> MapStudents(List<Database_Layer.Models.Student> students)
        {
            List<Student> mappedStudents = new List<Student>();

            foreach (Database_Layer.Models.Student student in students)
            {
                mappedStudents.Add(new Student()
                {
                    Id = student.Id,
                    Name = student.Name,
                    AvailableSlots = student.AvailableSlots
                });
            }

            return mappedStudents;
        }

        public static List<Database_Layer.Models.Student> MapStudentsDAO(List<Student> students)
        {
            List<Database_Layer.Models.Student> mappedStudents = new List<Database_Layer.Models.Student>();

            foreach (Student student in students)
            {
                mappedStudents.Add(new Database_Layer.Models.Student()
                {
                    Id = student.Id,
                    Name = student.Name,
                    AvailableSlots = student.AvailableSlots
                });
            }

            return mappedStudents;
        }

        public static Database_Layer.Models.Student MapStudentsDAO(Student student)
        {
            return new Database_Layer.Models.Student()
            {
                Id = student.Id,
                Name = student.Name,
                AvailableSlots = student.AvailableSlots
            };
        }

    }
}
