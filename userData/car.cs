using System;
namespace userDatabase
{
    public class car
    {
        private string make;
        private string model;
        private int year;
        private string liscenePlate;

        public car()
        {
            make = null;
            model = null;
            year = 0;
            liscenePlate = null;
        }
        public car(string m, string m2, int y, string lP)
        {
            make = m;
            model = m2;
            year = y;
            liscenePlate = lP;
        }
    }
}

