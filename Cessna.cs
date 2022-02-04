using System;

namespace graysGarage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }
     

        public void RefuelTank()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Cessna is a very depenable plane. 10/10");
            
        }

    }
}
