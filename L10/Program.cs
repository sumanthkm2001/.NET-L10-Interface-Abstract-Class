namespace L10
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile a1 = new Automobile() { EngineSize = 2.5 , NumTires = 4, Colour = "White"};
            Car c1 = new Car() { EngineSize = 5.4 , NumTires = 4, Colour = "Black" ,CarName="i20"};
            Truck t1 = new Truck() { EngineSize = 4.5, NumTires = 8, Colour = "Brown", TruckName = "Benz" };

            Console.WriteLine("\nEngine Size {0}.\nNumber of Tires {1}.\nColour {2}.",a1.EngineSize,a1.NumTires,a1.Colour);
            Console.WriteLine("\nEngine Size {0}.\nNumber of Tires {1}.\nColour {2}.\nCar Name {3}.", c1.EngineSize, c1.NumTires, c1.Colour,c1.CarName);
            Console.WriteLine("\nEngine Size {0}.\nNumber of Tires {1}.\nColour {2}.\nTruck Name {3}.", t1.EngineSize, t1.NumTires, t1.Colour,t1.TruckName);


            Console.Read();
        }
        class Automobile
        {
            public double EngineSize { get; set; }
            public int NumTires { get; set; }
            public string Colour { get; set; }
        }
        class Car : Automobile
        {
            public string CarName { get; set; }
        }
        class Truck : Automobile
        {
            public string TruckName { get; set; }
        }

    }
}