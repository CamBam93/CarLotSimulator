using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot lot = new CarLot();
            
            var car1 = new Car();
            car1.Year = 2017;
            car1.Make = "Subaru";
            car1.Model = "WRX";
            car1.EngineNoise = "Brrrrooooommmm!Sssstt!";
            car1.HonkNoise = "Meeeep!Meep!";
            car1.IsDriveable = true;
            lot.CarList.Add(car1);

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            Console.WriteLine("----------------");

            var car2 = new Car(2000, "Ford", "F250", "Bluub!Blup!Bluub!Blup!", "MMRRRRR!MMRRR!", true);
            lot.CarList.Add(car2);
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            Console.WriteLine("----------------");

            var car3 = new Car(){Year = 1969,Make = "Chevy",Model = "Nova",EngineNoise = "Vrrrrrrrooom!",HonkNoise = "Beeep!",IsDriveable = false};
            lot.CarList.Add(car3);
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            Console.WriteLine("----------------");



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"You have {CarLot.numberOfCars} cars in your lot.");
            Console.WriteLine("");
            foreach(var car in lot.CarList)
            {
                Console.WriteLine($"Year-{car.Year} Make-{car.Make} Model-{car.Model}");
                Console.WriteLine("----------");
            }
        }
    }
}
