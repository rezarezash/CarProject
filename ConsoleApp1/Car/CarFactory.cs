using ConsoleApp1.Contracts;
using System;

namespace ConsoleApp1.Car
{
    public class CarFactory
    {
        public static ICar GetCarInstance(Cars car)
        {
            switch (car)
            {
                case Cars.Toyota:
                    return new Toyota();
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public enum Cars
    {
        Toyota,
        Hyunadi
    }
}
