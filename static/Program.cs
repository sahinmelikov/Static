using staticInterface;

namespace staticinterface;
internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Console.WriteLine(Car.Id);
        car.Speed = 20;

        Car car1= new Car();
        Console.WriteLine(Car.Id);
        car1.Speed = 30;
        Car car2 = new Car();
        Console.WriteLine(Car.Id);
        car2.Speed = 100;

       Galery galery = new Galery();
        Console.WriteLine(galery.AddCar);
        Console.WriteLine(Galery.FindCarById);
        Console.WriteLine(galery.FindCarsByspeedInterval);

    }
}
