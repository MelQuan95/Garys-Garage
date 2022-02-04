using System;
using graysGarage;

namespace GarysGarage {


     public class Ram : Vehicle 
    {
        public double FuelCapacity { get; set; }
        

        public void RefuelTank()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Ram is pretty BA!! veryy nice very nice ");
            
        }
    }

}