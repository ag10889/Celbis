using System;
using System.Collections.Generic;
using System.IO;
namespace userDatabase
{
    
    public class lotInfo
    {
        private person name;
        private int DOB;
        private int DL;
        private car userCar;
        private bool reserved;
        private string reserveTimeTo;
        private string beginDate;
        private string reserveTime;
        private string endDate;

        List<lotInfo> availableLots = new List<lotInfo>();

        public lotInfo()
        {
            name = new person();
            reserved = true;
            reserveTimeTo = "12:00:00";
            reserveTime = "11:59:59";
        }
        public lotInfo(string userName, int num, int Dli, bool reservation, string timeTo, string timeFrom, string b, string e)
        {
            name = new person(userName, num, Dli);
            reserved = reservation;
            reserveTimeTo = timeTo;
            reserveTime = timeFrom;
            beginDate = b;
            endDate = e;
        }

        public void unavailableLot()
        {

        }

    }
}