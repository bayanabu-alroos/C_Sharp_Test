using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Person
{
    public sealed class Instructor : Person
    {
        private Instructor() { }
        public Instructor(string name, string phone, string nID, string email, string password, string specification, string address, string profileImage, string gender, string documentImage, string nationlity, string signiture)
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
        }

        ~ Instructor() { }
    }
}
