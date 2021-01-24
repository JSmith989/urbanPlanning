using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanning
{
    class City
    {
        //Fields
        private string _cityName;
        private DateTime _dateEstablished;

        //Properties
        public string Mayor { get; set; }

        //Constructor
        public City(string name)
        {
            _cityName = name;
        }

        //Methods
        public void AddBuilding(object building)
        {
            listOfBuildings.Add(building);
        }
        public void Establish()
        {
            _dateEstablished = DateTime.Now;
        }
        public void Display()
        {
            Console.WriteLine($@"
                {_cityName}
                Date Established: {_dateEstablished}
                Mayor: {Mayor}
                List of buildings:
            ");
        }

        //Collection
        public List<object> listOfBuildings = new List<object>();
    }
}
