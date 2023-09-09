using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Customer : Person
    {
        //public string Name
        //{  get
        //    {
        //        string name = Name;
        //        return name;
        //    }
        //    set
        //    {
        //        if (value != "")
        //        {
        //            Name = value;
        //        }
        //        Console.WriteLine("Invalid Name");
        //        throw new Exception("Invalid Name");
        //    }
        //}
        //public int IdNational { 
        //    get {
        //        int id = IdNational;
        //        return id;
        //    }
        //    set
        //    {
        //        if (value != null )
        //        {
        //            IdNational = value;
        //        }
        //        Console.WriteLine("Invalid Name");
        //        throw new Exception("Invalid Name");
        //    }
        //}
        //public string Phone { 
        //    get {
        //        string phone = Phone;
        //        return phone;
        //    }
        //    set
        //    {

        //    }
        //}

        public string DocumentType
        {
            get { 
                string type = DocumentType;
                return type; 
            }
            set
            {
                if (value != null)
                {
                    DocumentType = value;
                }
                Console.WriteLine("Invalid Name");
                throw new Exception("Invalid Name");
            }

        }
        /*
         *  polymorphism
         *  
         */



        public override double CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public Customer() { }
        public Customer(string name,string idNational,string phone,string documentType)
        {
            Name = name;
            IdNational = idNational;
            Phone = phone;
            DocumentType = documentType;
        }
        public Customer(string name)
        {
            Name = name;
        }


        ~ Customer() { }
         
    }
}
