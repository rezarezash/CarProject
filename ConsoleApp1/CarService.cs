using ConsoleApp1.Contracts;
using System;

namespace ConsoleApp1
{
    public class CarService
    {
        private readonly ICar _car;

        /// <summary>
        /// CarService Constructor
        /// </summary>
        /// <param name="car"></param>
        public CarService(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            _car = car;
        }

        /// <summary>
        /// AccelerateTheCar 
        /// </summary>
        /// <param name="amount"></param>
        public void AccelerateTheCar(int amount = 1)
        {
            _car.Accelerate(amount);
        }

        /// <summary>
        /// DecelerateTheCar
        /// </summary>
        /// <param name="amount"></param>
        public void DecelerateTheCar(int amount = 1)
        {
            _car.Decelerate(amount);
        }

        /// <summary>
        /// TurnLeftTheCar
        /// </summary>
        public void TurnLeftTheCar()
        {
            _car.TurnLeft();
        }

        /// <summary>
        /// TurnRightTheCar
        /// </summary>
        public void TurnRightTheCar()
        {
            _car.TurnRight();
        }

        /// <summary>
        /// IncreaseCarRadioVolume
        /// </summary>
        public void IncreaseCarRadioVolume()
        {
            _car.IncreaseRadioVolume();
        }

        /// <summary>
        /// DecreaseCarRadioVolume
        /// </summary>
        public void DecreaseCarRadioVolume()
        {
            _car.DecreaseRadioVolume();
        }

        /// <summary>
        /// Get car speed
        /// </summary>
        public int GetCurrentSpeed()
        {
            return _car.GetCarSpeed();
        }
    }
}
