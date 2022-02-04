using System;
using graysGarage;

namespace GarysGarage {
    public class Tesla : Vehicle, IelectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 98;
        }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Tesla is very ugly but boyyy is it a nice drive!");
            
        }

         public override void Turn()
    {
        Console.WriteLine("Tesla went for a har left turn!!");
    }
         public override void Stop()
    {
        Console.WriteLine("srrrttt! to the stop sign!!");
    }
    }

}