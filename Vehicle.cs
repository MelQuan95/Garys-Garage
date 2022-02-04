using System;


namespace graysGarage
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Car go Vroom!!");
        }

         public virtual void Turn()
        {
            Console.WriteLine("turn left at the light");
        }

         public virtual void Stop()
        {
            Console.WriteLine("stop at stop sign!");
        }
    }

}
    

     

  