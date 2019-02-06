using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Lab
{
    class NorthAmericanDatabase
    {
        public List<Country> Countries;

        public NorthAmericanDatabase()
        {
            string[] USColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("USA", "English", "Hello World!", USColors));
            string[] MexicoColors = { "Red", "White", "Green" };
            Countries.Add(new Country("Mexico", "Spanish", "Hola Mundo!", MexicoColors));
            string[] CanadaColors = { "Red", "White" };
            Countries.Add(new Country("Canada", "English and French", "Bon jour mundo", CanadaColors));

        }
    }
}
