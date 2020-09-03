namespace GarysGarage
{
    public interface IRealRide
    {
        int CurrentTankPercentage { get; set; }

        public void RefuelTank();
    }

}