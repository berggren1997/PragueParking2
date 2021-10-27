﻿using System;

namespace Prague_Parking_2._0
{
    //[Serializable]
    public class Vehicle
    {
        public string VehicleType { get; set; } //typen är INTE till för att definiera vilken typ som ska läggas till, utan har bara en vehicletype för att göra en klarare utskrift
        public string RegNr { get; set; }
        public DateTime CheckIn { get; set; }
        public int Size { get; set; }


        public override string ToString()
        {
            return "Registration number: " + RegNr;
        }

    }
}
