using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Contracts
{
    public sealed class Contract
    {
        private Contract() { }
        public Contract(DateOnly startDate, DateOnly endDate, string jobType, float totalDues, float remainingDues, string introduction, List<Condtions> conditions, List<PayedDues> payedDues)
        {
            StartDate = startDate;
            EndDate = endDate;
            JobType = jobType;
            TotalDues = totalDues;
            RemainingDues = remainingDues;
            Introduction = introduction;
            Conditions = conditions;
            PayedDues = payedDues;
        }

        public DateOnly StartDate { get; set; }
         
        public DateOnly EndDate { get; set; }
        public string JobType { get; set; }
         
        public float TotalDues { get; set; }
         
        public float RemainingDues { get; set; }
        public string Introduction { get; set; }
        public List<Condtions> Conditions { get; set; }
         
        public List<PayedDues> PayedDues { get; set;}

        ~ Contract() { }
    }
}
