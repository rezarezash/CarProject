using ConsoleApp1.Contracts;
using System;

namespace ConsoleApp1.Car
{
    public abstract class Car : ICar
    {
        #region private/public memebers
        public int _speed = 0; // the naming convention is not right here for a public variable intentially left it as it is
        public int _angle = 0;
        public int _radioVolume = 0;
        public int _decelerateForTurn = 1;
        public virtual int MaxAngle { get; private set; } = 45;
        public virtual int MaxSpeed { get; private set; } = 320;
        public virtual int MinAngle { get; private set; } = -45;
        public virtual int MaxVolumeDb { get; private set; } = 140;

        #endregion private/public memebers

        #region Methods 
        public abstract void Accelerate(int amountToAccelerate = 1);

        public abstract void Decelerate(int amountToDecelarate = 1);

        public abstract void DecreaseRadioVolume();

        public virtual double GetVolume()
        {
            var amplification = Math.Round(_speed / 10.0);
            var volume = _radioVolume + amplification;
            return volume < MaxVolumeDb ? volume : MaxVolumeDb;
        }

        public abstract void IncreaseRadioVolume();

        public abstract void TurnLeft();

        public abstract void TurnRight();

        public virtual int GetCarSpeed()
        {
            return _speed;
        }

        #endregion
    }
}
