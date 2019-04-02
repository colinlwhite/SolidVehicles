using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidVehicles.Interfaces;

namespace SolidVehicles.Vehicles
{
    public class Boat : IVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 8;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "engine";
        public double EngineVolume { get; set; } = 100;
        public double MaxWaterSpeed { get; set; } = 200;
        public double MaxLandSpeed { get; set; } = 0.0;
        public double MaxAirSpeed { get; set; } = 0.0;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

}
