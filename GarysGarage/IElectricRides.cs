namespace GarysGarage
{
    public interface IElectricRides
    {
        int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }

}