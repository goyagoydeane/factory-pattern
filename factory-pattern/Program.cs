using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            //=========MENU=========//
            //*Cheese *Veggies *Clam//

            Console.WriteLine("Pizzeria A:");
            var pizzeriaA = new PizzeriaA();
            pizzeriaA.Order("Veggies");
            Console.WriteLine();
            Console.WriteLine("Pizzeria B:");
            var pizzeriaB = new PizzeriaB();
            pizzeriaB.Order("Clam");

            Console.ReadLine();
        }
    }
}
