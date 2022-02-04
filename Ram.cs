using System;
using graysGarage;

namespace GarysGarage {


     public class Ram : Vehicle, IGasvehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 50;
        }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Ram is pretty BA!! veryy nice very nice ");
            
        }
    }

}