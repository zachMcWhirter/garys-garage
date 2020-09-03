namespace GarysGarage
{
    public interface IRealRides
    {
        int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
    }

}