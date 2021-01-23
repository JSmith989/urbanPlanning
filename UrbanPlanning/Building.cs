using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanning
{
    class Building
    {

        // you will need this collection at some point List<int> myListOfIntegers = new List<int>();

        //Fields
        private string _designer = "Jordan Smith";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        //Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        //Volume property read only and returns math
        public double Volume { get { return Width * Depth * (3 * Stories); } }

        //Constructor
        public Building(string address)
        {
            _address = address;
        }

        //Method
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            _owner = name;
        }
        public void ShowInfo()
        {
            Console.WriteLine($@"
                {_address}
                Designed by {_designer}
                Date Constructed: {_dateConstructed}
                Owner: {_owner}
                {Volume} cubic meters of space
            ");
        }
    }
}
