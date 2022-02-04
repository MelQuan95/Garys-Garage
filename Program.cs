using System;
using GarysGarage;

namespace graysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GARYS GARAGE!");

            Zero Fisker = new Zero
            {
                MainColor = "Black"
            };

            Tesla CyberTruck = new Tesla()
            {
                MainColor = "Hunter Green"
            };

            Cessna BigPlane = new Cessna()
            {
                MainColor = "Orange"
            };

        Ram TRX = new Ram()
        {
            MainColor = "Matte Silver"
        };


        Fisker.Drive();
        CyberTruck.Drive();
        BigPlane.Drive();
        TRX.Drive();

        TRX.Turn();
        TRX.Stop();
        }
    }
}
