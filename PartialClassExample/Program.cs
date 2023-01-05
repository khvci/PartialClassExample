using PartialClassExample;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Corolla", 2005);
        car1.Start();
        Console.WriteLine(car1.Speed);

        car1.Accelerate(30);
        Console.WriteLine(car1.Speed);

        car1.SlowDown(5);
        Console.WriteLine(car1.Speed);

        car1.Accelerate(30);
        Console.WriteLine(car1.Speed);
        
        car1.Stop();
        car1.StopEngine();

        
    }
}