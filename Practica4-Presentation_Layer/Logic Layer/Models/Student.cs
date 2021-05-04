using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Layer.Models
{
    // DTO = Data Transfer Objects
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int AvailableSlots { get; set; }
    }
}