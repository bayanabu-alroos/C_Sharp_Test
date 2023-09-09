using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Contracts
{
    public sealed class PayedDues
    {
        private PayedDues() { }
        public PayedDues(double amount, DateOnly dueDate, DateOnly payedDate, string adminSignture, int instructorSignture)
        {
            Amount = amount;
            DueDate = dueDate;
            PayedDate = payedDate;
            AdminSignture = adminSignture;
            InstructorSignture = instructorSignture;
        }

        public double Amount { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly PayedDate { get; set; }
        public string AdminSignture { get; set; }
        public int InstructorSignture { get; set; }

        ~ PayedDues() { }
    }
}
