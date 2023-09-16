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
        List<lotInfo> unavailableLots = new List<lotInfo>();

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
        public void countAvailableLots()
        {
            //Ok so I'll need some help here, because this size will vary upon which lot we have. So basically I am planning to add until there is no more
            availableLots.Add(new lotInfo());
        }
        public void addReservation(person customer,string beginngDay, string endDay, string timeReserved, string timeTo)
        {
            unavailableLots.Add(new lotInfo(customer, true, timeTo, timeReserved, beginngDay, endDay));
            
        }

    }
}