using System;
using System.Collections.Generic;
using GarysGarage;

namespace graysGarage
{
    class Program
    {

        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IelectricVehicle> electricVehicles = new List<IelectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IelectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IelectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();


            }

            foreach (IelectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasvehicle> gasVehicles = new List<IGasvehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasvehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasvehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasvehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
            //         {
            //             Console.WriteLine("GARYS GARAGE!");

            //             Zero Fisker = new Zero
            //             {
            //                 MainColor = "Black"
            //             };

            //             Tesla CyberTruck = new Tesla()
            //             {
            //                 MainColor = "Hunter Green"
            //             };

            //             Cessna BigPlane = new Cessna()
            //             {
            //                 MainColor = "Orange"
            //             };

            //         Ram TRX = new Ram()
            //         {
            //             MainColor = "Matte Silver"
            //         };


            //         Fisker.Drive();
            //         CyberTruck.Drive();
            //         BigPlane.Drive();
            //         TRX.Drive();

            //         TRX.Turn();
            //         TRX.Stop();
            //         }
        }
    }
}

