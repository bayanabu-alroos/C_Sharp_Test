using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("The first name must not be empty or null");
                    }
                }catch(Exception error) {
                    Console.WriteLine(error.ToString());
                }
               

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("The last name must not be empty or null");
                    }
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
                

                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 150)
                    {
                        throw new ArgumentException("The age must be between 1 and 150");
                    }
                    
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
                

                age = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }

}
