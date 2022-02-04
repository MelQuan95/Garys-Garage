using System;
using GarysGarage;

namespace graysGarage
{
    public class Cessna : Vehicle, IGasvehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"the {MainColor} Cessna is a very depenable plane. 10/10");

        }

    }
}
