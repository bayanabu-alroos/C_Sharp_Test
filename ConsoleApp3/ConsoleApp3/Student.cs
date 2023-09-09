using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Student
    {
        string name;
        float grades;
        public float CalculateAverageGrade()
        {
            float[] grades = { 8, 9, 13, 15 };
            float sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            float avarage = sum / grades.Length;

            return avarage;
        }
    }
}
