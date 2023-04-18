using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticinterface
{
    internal class Car
        {

        public Car()
        {
          
           
            Id++;
           
        }
        public static int count=Convert.ToInt32(Console.ReadLine());
        public static int Id;
        public string Name;
        public string Color;
        public double Speed;
        }
}
