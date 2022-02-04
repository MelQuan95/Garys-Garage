namespace GarysGarage 
{
    public interface IGasvehicle
    {
        double CurrentTankPercentage {get; set;}
        void RefuelTank();

    }
}