using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Lab
{
    class CountryViewer
    {
        public void ContView()
        {
            Console.WriteLine("What continent would you like to learn about? \n" + "1. North America \n" + "2. Asia \n");
        }
        public void LoopFalse()
        {
            Console.WriteLine("Wrong input, please try again. \n");
        }
        public void PickAmerica()
        {
            Console.WriteLine("Pick a country in North America.");
        }
        public void PickAsia()
        {
            Console.WriteLine("Pick a country in Asia.");
        }
        public void AmericaCountryChoice()
        {

        }
    }
}
