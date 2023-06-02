using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsHomeApp3
{
    internal class Student
    {
        public string? Name { get; set; }
        public string ? Surname { get; set; }
        public string ? Email { get; set; }
        public string ? Phone { get; set; }
        DateTime? BirthDate { get; set; }
        public Student() { }

        public override string ToString()
        {
            return $"Name : {Name } \nSurname : {Surname } \nEmail : {Email } \nPhone : {Phone } \nBirthdate : {BirthDate.ToString()}";
        }
    }
}
