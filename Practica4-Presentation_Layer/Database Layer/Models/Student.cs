using System;
using System.Collections.Generic;
using System.Text;

namespace Database_Layer.Models
{
    //DAO = Data Access Object
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int AvailableSlots { get; set; }
    }
}
