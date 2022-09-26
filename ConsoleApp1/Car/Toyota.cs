using System;

namespace ConsoleApp1.Car
{
    public class Toyota : Car
    {
        /// <summary>
        /// SetInitialSpeed
        /// </summary>
        /// <param name="speed">int</param>
        public void SetInitialSpeed(int speed)
        {
            _speed = speed;
        }

        /// <summary>
        /// Accelrate the car
        /// </summary>
        public override void Accelerate(int amountToAccelerate)
        {
            if (_speed == MaxSpeed || amountToAccelerate > MaxSpeed)
            {
                return;
            }
            _speed += amountToAccelerate;
        }

        /// <summary>
        /// Decelerate the car
        /// </summary>
        public override void Decelerate(int amountToDecelarate)
        {
            if (_speed == 0 || amountToDecelarate < 0)
            {
                return;
            }
            _speed -= amountToDecelarate;
        }

        /// <summary>
        /// Decrease radio volume
        /// </summary>
        public override void DecreaseRadioVolume()
        {
            _radioVolume--;
        }

        /// <summary>
        /// Increase radio volume
        /// </summary>
        public override void IncreaseRadioVolume()
        {
            _radioVolume++;
        }

        /// <summary>
        ///   Turn left
        /// </summary>
        public override void TurnLeft()
        {
            if (_angle == MinAngle)
            {
                return;
            }
            _angle--;
            Decelerate(_decelerateForTurn);
        }

        /// <summary>
        /// Turn right
        /// </summary>
        public override void TurnRight()
        {
            if (_angle == MaxAngle)
            {
                return;
            }
            _angle++;
            Decelerate(_decelerateForTurn);
        }
    }
}
