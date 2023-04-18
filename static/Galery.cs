using staticinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace staticInterface
{
    internal class Galery
    {

        public int Id;

        

      
        public void  AddCar()
        {
            
            Car[] cars = new Car[5];
            foreach (var car in cars)
            {
                Console.WriteLine(car);

            }



        }
       
        public static  void FindCarById(Car Id,Car count)
        {
            
          
            Car car = new Car();
            if (Car.Id == Car.count)
            {
                Console.WriteLine(car);
            }

            
            

        }

     public void FindCarsByspeedInterval() 
        {
            Car car= new Car();
            if (car.Speed>20 && car.Speed<100)
            {
                Console.WriteLine(car.Speed);
            }
            Console.WriteLine("Araliq");
        }
      


    }

    
}
