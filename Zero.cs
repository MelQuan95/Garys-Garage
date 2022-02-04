using System;
using GarysGarage;

namespace graysGarage
{
    public class Zero : Vehicle, IelectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Zero is quick as light!!! rhhhmmmmmmmmmmm");
            
        }
        
    }

}