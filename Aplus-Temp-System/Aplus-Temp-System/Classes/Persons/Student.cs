using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Person
{
    public sealed class Student : Person
    {
        private Student() { }

        public string Birthdate { get; set; }


        public Student(string name, string phone, string nID, string email, string password, string specification, string address, string profileImage, string gender, string documentImage, string nationlity, string signiture, string birthdate) 
            : base(name, phone, nID, email, password, specification, address, profileImage, gender, documentImage, nationlity, signiture)
        {
            Name = name;
            Phone = phone;
            NID = nID;
            Email = email;
            Password = password;
            Specification = specification;
            Address = address;
            ProfileImage = profileImage;
            Gender = gender;
            DocumentImage = documentImage;
            Nationlity = nationlity;
            Signiture = signiture;
            Birthdate = birthdate;
        }

        ~ Student() { }

    }
}
