﻿using System;
using System.IO;

namespace Prague_Parking_2._0
{
    public class MC : Vehicle
    {
        //public MC() // för ett test..
        //{
        //    Size = 2;
        //}
        public MC(string regNumber) : base(regNumber)
        {
            VehicleType = "MOTORCYCLE";
            //RegNr = regNumber;
            Size = 2;
            CheckIn = DateTime.Now;
            
        }

        public override string ToString()
        {
            return "";
        }
    }
}
