namespace GarysGarage
{
    public interface IElectricRide
    {
        int CurrentChargePercentage { get; set; }

        public void ChargeBattery();
    }

}