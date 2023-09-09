using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Person
{
    public abstract class Person
    {
        protected Person() { }
        protected Person(string name, string phone, string nID, string email, string password, string specification, string address, string profileImage, string gender, string documentImage, string nationlity, string signiture)
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
        }

        protected string Name { get; set; }
        protected string Phone { get; set; }
        protected string NID { get; set; }

        protected string Email { get; set; }

        protected string Password { get; set; }

        protected string Specification { get; set; }

        protected string Address { get; set; }

        protected string ProfileImage { get; set; }
        protected string Gender { get; set; }

        protected string DocumentImage { get; set; }

        protected string Nationlity { get; set; }

        protected string Signiture { get; set; }

        ~ Person() { }

    }
}
