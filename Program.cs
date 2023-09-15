using System;
using System.Collections.Generic;
using System.IO;

public class car
{
    private string make;
    private string model;
    private int year;
    private string liscenePlate;

    public car(string m, string m2, int y, string lP)
    {
        make = m;
        model = m2;
        year = y;
        liscenePlate = lP;
    }
}
public class person
{
    private string name;
    private int DOB;
    private int DLnumber;
    public person(string n, int D, int DL)
    {
        name = n;
        DOB = D;
        DLnumber = DL;
    }
    public person()
    {
        name = "Fuentes, Evan";
        DOB = 42069;
        DLnumber = 111111111;
    }
    public string getName()
    {
        return name;
    }

}

public class lotInfo 
{
    private string name;
    private int number;
    private car userCar;
    private bool reserved;
    private string reserveTimeTo;
    private string reserveTime;

    public lotInfo()
    {
        name = "Salter, Bridgette";
        number = 0;
        reserved = true;
        reserveTimeTo = "12:00:00";
        reserveTime = "11:59:59";
    }
    public lotInfo(string userName, int num, bool reservation, string timeTo, string timeFrom)
    {
        name = userName;
        number = num;
        reserved = reservation;
        reserveTimeTo = timeTo;
        reserveTime = timeFrom;
    }
    
}