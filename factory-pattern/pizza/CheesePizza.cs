﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    class CheesePizza : Pizza
    {
        readonly IIngredientsFactory _ingredients;

        public CheesePizza(IIngredientsFactory ing)
        {
            _ingredients = ing;
        }
        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + Name + " Using");
            Console.Write("Dough: " + _ingredients.CreateDough().Name + ", Cheese: " + _ingredients.CreateCheese().Name + ", Sauce: " + _ingredients.CreateSauce().Name + ", Veggies: ");
            Console.WriteLine();
            foreach (var val in _ingredients.CreateVeggies())
            {
                Console.Write(val.Name + " ");
            }
            Console.WriteLine();
        }
    }
}
