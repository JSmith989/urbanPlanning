using System;

namespace UrbanPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue")
            {
                Width = 30.7,
                Depth = 60.3,
                Stories = 4,
            };
            Building SearsTower = new Building("233 S. Wacker Dr.")
            {
                Width = 225,
                Depth = 100.5,
                Stories = 108,
            };
            Building FarmHouse = new Building("1314 W. Cullerton St.")
            {
                Width = 40,
                Depth = 40,
                Stories = 1,
            };

            FarmHouse.Construct();
            SearsTower.Construct();
            FiveOneTwoEight.Construct();

            FarmHouse.Purchase("Michael Jordan");
            SearsTower.Purchase("Holly Smith");
            FiveOneTwoEight.Purchase("Gordon Ramsay");

            FarmHouse.ShowInfo();
            SearsTower.ShowInfo();
            FiveOneTwoEight.ShowInfo();
        }
    }
}
