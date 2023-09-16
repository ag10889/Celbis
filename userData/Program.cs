using System;
using System.Collections.Generic;
using System.IO;
namespace userDatabase
{
    
    public class lotInfo
    {
        private person name;
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
            reserved = false;
            reserveTimeTo = "12:00:00";
            reserveTime = "11:59:59";
        }
        public lotInfo(person customer, bool reservation, string timeTo, string timeFrom, string b, string e)
        {
            name = customer;
            reserved = reservation;
            reserveTimeTo = timeTo;
            reserveTime = timeFrom;
            beginDate = b;
            endDate = e;
        }

        public void addReservation(person customer,string beingDay, string endDay, string timeReserved, string timeTo)
        {

        }

    }
}