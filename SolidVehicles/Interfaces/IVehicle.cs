﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles.Interfaces
{
    public interface IVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        bool Winged { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        double MaxLandSpeed { get; set; }
        double MaxAirSpeed { get; set; }
        void Start();
        void Stop();
        void Drive();
        void Fly();
    }

}
