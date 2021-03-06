﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    public abstract class CarDetails
    {
        public String carname;
        public String carnumber;
        abstract public void Getcarinfo(string carname,string carnumber);
    }

    public interface RateDetails
    {
       void getdays();
       void getkm();
    }

    public class Customer : CarDetails, RateDetails
    {
        private float rate_km = 7.7f;
        private float rate_day = 500;
        public int getday;
        public int getkm;

        public override void Getcarinfo(string carname, string carnumber)
        {
            String Carname = carname;
            String Carnumber = carnumber;
            Console.WriteLine("Car Name : {0} ",Carname);
            Console.WriteLine("Car Number : {0} ", Carnumber);
        }

        public void get_day()
        {
            Console.WriteLine("Enter Number of days");
            getday = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(rate_day);
        }

        public void get_km()
        {
            Console.WriteLine("Enter Killo Meter");
            getkm = Convert.ToInt32(Console.ReadLine());
        }

        public void getdays()
        {
            throw new NotImplementedException();
        }

        void RateDetails.getkm()
        {
            throw new NotImplementedException();
        }

        public void calrate()
        {
            float ratekm = rate_km * getkm;
            float rateday = rate_day * getday;
            float total = ratekm + rateday;
            Console.WriteLine("Total Km Rate : {0} ",ratekm);
            Console.WriteLine("Total Day Rate : {0} ", rateday);
            Console.WriteLine("Total Amount of Journy  : {0} ", total);
        }
    }
}
