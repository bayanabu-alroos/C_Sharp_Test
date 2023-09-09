using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StuffedCrustPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prearing Stuffed  Crust Pizza");
        }
        Car bmmw = new Car();

        interface IBasicCarFunctions
        {
            void StartEngine();
            void StopEngine();
            void RunAtFullSpeed();
        }

        class Car : IBasicCarFunctions, IEntertainmenttSystem
        {
            public string CarBrand { get; set; }
            public decimal CarPrice { get; set; }

            public int EnginCapcity { get; set; }

            public void NextMediaItem()
            {
                throw new NotImplementedException();
            }

            public void PreviousMediaItem()
            {
                throw new NotImplementedException();
            }

            public void RunAtFullSpeed()
            {
                throw new NotImplementedException();
            }

            public void StartEngine()
            {
                throw new NotImplementedException();
            }

            public void StopEngine()
            {
                throw new NotImplementedException();
            }

            public void StopMedia()
            {
                throw new NotImplementedException();
            }
        }

        interface IEntertainmenttSystem
        {
            void StopMedia();
            void NextMediaItem();
            void PreviousMediaItem();


        }
    }
}

