using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.Enum;
using FleetSim.Objects.Interface;

namespace FleetSim.Console
{
    class Program
    {
        static void carCheck()
        {
            List<Car> cars = new List<Car>()
            {
                new Car() { year = 1966, make="Ford", model="Mustang", carColor=ColorOptions.red, vin = Guid.NewGuid(), mileage = 0, lastServicedMileage = 0},
                new Car() { year = 1967, make="Chevrolet", model="Camaro", carColor=ColorOptions.blue, vin = Guid.NewGuid(), mileage = 0, lastServicedMileage = 0},
                new Car() { year = 1990, make="Dodge", model="Viper", carColor=ColorOptions.white, vin = Guid.NewGuid(), mileage = 0, lastServicedMileage = 0},
                new Car() { year = 1935, make="Ford", model="Phaeton Restomod", carColor=ColorOptions.blue, vin = Guid.NewGuid(), mileage = 0, lastServicedMileage = 0},
                new Car() { year = 1968, make="Pontiac", model="Lemans", carColor=ColorOptions.red, vin = Guid.NewGuid(), mileage = 0, lastServicedMileage = 0}
            }; 

            foreach (var myCar in cars)
            {
                for (int counter = 0; counter < 10; counter++)
                { 
                    Random rnd = new Random();
                    int newMileage = rnd.Next(5000, 15000);
                    myCar.mileage = myCar.mileage + newMileage;
                    myCar.TuneUp(myCar.mileage, myCar.lastServicedMileage, myCar.lastServicedDate, myCar.model);

                };
            }

        }



        static void Main(string[] args)
        {
            try
            {
                carCheck();
            }
            catch (ArgumentNullException ane)
            {
                System.Console.WriteLine("Argument Null Exception caught.", ane);
            }
            catch (InvalidCastException ice)
            {
                System.Console.WriteLine("Invalid Cast Exception caught.", ice);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}
