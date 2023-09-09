using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Contract
    {
        string name;
        string Title { get; set; }

        string Description { get; set; }

        string StartDate { get; set; }

        string EndDate { get; set; }
        float Price { get; set; }
        int Days { get; set; }  

        private Contract() 
        { 
            //deafult Constractor 
        }

        public Contract(string title, string description, string startDate, string endDate, float price, int days)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
            Days = days;
            // Constructors
        }

        public Contract(string title, string description, string startDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
        }

        ~ Contract() { }    
    }
}
