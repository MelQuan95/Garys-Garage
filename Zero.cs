using System;

namespace graysGarage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }


        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Zero is quick as light!!! rhhhmmmmmmmmmmm");
            
        }
        
    }

}