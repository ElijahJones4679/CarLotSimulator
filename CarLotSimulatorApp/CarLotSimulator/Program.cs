using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Done : *
            // * Create a seperate class file called Car
            // * Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // * Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            // * The methods should take one string parameter: the respective noise property


            // * Now that the Car class is created we can instanciate 3 new cars
            // * Set the properties for each of the cars
            // * Call each of the methods for each car

            var lot = new CarLot();
            

            // * Dot Notation
            var aCar = new Car();
           
            aCar.Make = "Ford";
            aCar.Model = "F-150";
            aCar.Year = 2018;
            aCar.EngineNoise = "vroom";
            aCar.HonkNoise = "beep beep";
            aCar.IsDrivable = true;

            lot.Cars.Add(aCar);
            Console.WriteLine($"The number of cars in the carlot is: {CarLot.numberofCars}");
            Console.WriteLine();
            




            // * Object Initializer Syntax
            var bCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Model 3",
                EngineNoise = "...",
                HonkNoise = "brmmmp",
                IsDrivable = true,
            };

            lot.Cars.Add(bCar);
            Console.WriteLine($"The number of cars in the carlot is: {CarLot.numberofCars}");
            Console.WriteLine();
            


            // * Consttuctor 
            var cCar = new Car(2022, "Honda", "Civic", "vrrrrooom", "vruuuga", true);

            lot.Cars.Add(cCar);
            Console.WriteLine($"The number of cars in the carlot is: {CarLot.numberofCars}");
            Console.WriteLine();
           


            // * Call methods
            /*                aCar.MakeEngineNoise(aCar.EngineNoise);
                            bCar.MakeEngineNoise(bCar.EngineNoise);
                            cCar.MakeEngineNoise(cCar.EngineNoise);
            */
            //*************BONUS*************// 

            // * Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            // * Create a CarLot class
            // * It should have at least one property: a List of cars
            // * Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            // * At the end iterate through the list printing each of car's Year, Make, and Model to the console

/*            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
*/
        }
    }
}
