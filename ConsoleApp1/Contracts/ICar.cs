namespace ConsoleApp1.Contracts
{
    /// <summary>
    /// The interface for a Car
    /// </summary>
    public interface ICar
    {
        void TurnLeft();
        void TurnRight();
        void Accelerate(int amountToAccelerate);
        void Decelerate(int amountToDecelarate);
        double GetVolume();
        void IncreaseRadioVolume();
        void DecreaseRadioVolume();
        int GetCarSpeed();
    }
}
