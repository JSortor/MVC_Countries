using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Lab
{
    class NorthAmericanDB
    {
        public List<Country> Countries = new List<Country>();

        public NorthAmericanDB()
        {
            string[] USColor = { "Red", "White", "Blue" };
            string[] CNColor = { "Red", "White" };
            string[] MXColor = { "Red", "White", "Green" };
            
            

            Country USA = new Country("USA", "English", "Hello World", USColor);
            Country CAN = new Country("Canada", "English", "Hello eh", CNColor);
            Country MEX = new Country("Mexico", "Spanish", "Hola Mundo", MXColor);
            Country CUB = new Country("Cuba", "Spanish", "Hola Mundo", USColor);
            Country DOM = new Country("Dominican Republic", "Spanish", "Hola Mundo", USColor);
            Countries.Add(USA); Countries.Add(CAN); Countries.Add(MEX); Countries.Add(CUB); Countries.Add(DOM);
        }
    }
}
