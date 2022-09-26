using ConsoleApp1.Car;
using System;
using System.Dynamic;
using Xunit;

namespace Car.Test
{
    public class ToyotaTests
    {
        [Fact]
        public void If_Speed_Is_Max_Speed_Should_Not_Change()
        {
            /*
              because coded against contratcs - here we can also imlement a fake class instead of using the 
              factory
            */

            // Arrange
            var car = (Toyota)CarFactory.GetCarInstance(Cars.Toyota);

            // Assign 
            int currentSpeed = 320;
            // Act
            car.Accelerate(currentSpeed); // Set the speed to max
            car.Accelerate(1); // Accelerate by 1

            // Assert
            Assert.Equal(currentSpeed, car._speed);
        }

        [Fact]
        public void If_Turn_Right_Angle_ShouldNot_Go_Morethan_Max()
        {
            // Arrange
            var car = (Toyota)CarFactory.GetCarInstance(Cars.Toyota);

            // Assign 
            int expectedAngle = 45;

            // Act
            for (int i = 0; i < 45; i++)
            {
                car.TurnRight();
            }

            Assert.Equal(expectedAngle, car._angle);
        }

        [Fact]
        public void If_Turn_Left_Angle_ShouldNot_Go_Lessthan_Min()
        {
            // Arrange
            var car = (Toyota)CarFactory.GetCarInstance(Cars.Toyota);

            // Assign 
            int expectedAngle = -45;

            // Act
            for (int i = 0; i < 45; i++)
            {
                car.TurnLeft();
            }

            Assert.Equal(expectedAngle, car._angle);
        }

        [Fact]
        public void If_Wrong_Type_Request_NotImplemented_Shouldbe_Thrown()
        {
            // Arrange
            Assert.Throws<NotImplementedException>(() => (Toyota)CarFactory.GetCarInstance(Cars.Hyunadi));           
        }

    }
}
