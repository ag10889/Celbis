using System;
using System.Collections.Generic;
namespace userDatabase
{
    public class person
    {
        private string name;
        private int DOB;
        private int DLnumber;
        private string phoneNumber;
        public person(string n, int D, int DL)
        {
            name = n;
            DOB = D;
            DLnumber = DL;
        }
        public person()
        {
            name = null;
            DOB = 0;
            DLnumber = 0;
        }

    }
}

