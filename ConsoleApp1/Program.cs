using ConsoleApp1.Car;
using ConsoleApp1.Contracts;
using Microsoft.Extensions.DependencyInjection;

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var serviceCollection = new ServiceCollection()
                        .AddScoped<ICar, Toyota>();
                var serviceProvider = serviceCollection.BuildServiceProvider();

                var car = serviceProvider.GetService<ICar>();
                var carService = new CarService(car);
                carService.AccelerateTheCar(10);
                carService.TurnLeftTheCar();
                carService.TurnRightTheCar();
                carService.AccelerateTheCar(100);
                carService.TurnRightTheCar();
                Console.WriteLine(carService.GetCurrentSpeed());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
