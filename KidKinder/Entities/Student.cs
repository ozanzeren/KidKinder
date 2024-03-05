using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string Veli1 { get; set; }
        public string Veli2 { get; set; }
        public string Veli3 { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}