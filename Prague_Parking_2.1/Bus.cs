﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prague_Parking_2._1
{
    public class Bus : Vehicle
    {
        public Bus(string regNumber): base(regNumber)
        {
            VehicleType = "BUS";
            Size = Configuration.BusSize;
            CheckIn = DateTime.Now;
        }
    }
}
