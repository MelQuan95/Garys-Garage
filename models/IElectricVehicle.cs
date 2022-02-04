namespace GarysGarage
{
    public interface IelectricVehicle
    {
        double CurrentChargePercentage {get; set;}
        void ChargeBattery();

    }
}