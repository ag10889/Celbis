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


        private Node head = null;
        StreamReader sr = new StreamReader("par-x.vercel.app/reserve.html");

        public static int convertTimeToSecond(string timeString)
        {
            string[] parts = timeString.Split(':', 3);
            if (timeString.Length != 8)
            {
                throw new InvalidTimeException("Invalid time format has been entered.");
            }
            int hours, minutes, seconds;
            if (!int.TryParse(parts[0], out hours) || !int.TryParse(parts[1], out minutes) || !int.TryParse(parts[2], out seconds))
            {
                throw new InvalidTimeException("Invalid time format has been entered, please enter numerical values. ");
            }

            if (hours == null || hours < 0 || hours > 23)
            {
                throw new InvalidTimeException("Hours must be less than 24: " + hours);
            }

            if (minutes == null || minutes < 0 || minutes > 59)
            {
                throw new InvalidTimeException("Minutes must be less than 60: " + minutes);
            }

            if (seconds == null || seconds < 0 || seconds > 59)
            {
                throw new InvalidTimeException("Seconds must be less than 60: " + seconds);
            }


            return (hours * 60 * 60) + (minutes * 60) + seconds;

        }

        public lotInfo() 
        {
            name = new person();
            userCar = new car();
            reserved = false;
            reserveTimeTo = "12:00:00";
            reserveTime = "11:59:59";
            
        }
        public lotInfo(person customer, bool reservation, string timeTo, string timeFrom, string b, string e, car userCar)
        {
            name = customer;
            this.userCar = userCar;
            reserved = reservation;
            reserveTimeTo = timeTo;
            reserveTime = timeFrom;
            beginDate = b;
            endDate = e;
        }
        
        public void add(person c, bool r, string t, string tf, string b, string e, car cust)
        {
            lotInfo newLot = new lotInfo(c, r, t, tf, b, e, cust);
            Node newNode = new Node(newLot);
            if (head == null) 
            {
                head = newNode;
            }
            else 
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }
        public void show_all()
        {
            Node current = head; 
            while (current != null) 
            {
                Console.WriteLine(current.lot.ToString());
                current = current.next;
            }

        }
        public void delete(lotInfo lot)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Equals(lot))
                {
                    head = current.next;
                    current = null;
                }
            }
        }


    }
}