using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    internal class PizzeriaBIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese()
        {
            return new Parmesan();
        }

        IClam IIngredientsFactory.CreateClam()
        {
            return new FreshClam();
        }

        IDough IIngredientsFactory.CreateDough()
        {
            return new DeepDish();
        }

        ISauce IIngredientsFactory.CreateSauce()
        {
            return new PlumTomato();
        }

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies()
        {
            IVeggies[] arr = { new Cucumber(), new Onion(), new Pepper() };
            return arr;
        }
    }
}
