using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    internal class PizzeriaAIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese()
        {
            return new Mozarella();
        }

        IClam IIngredientsFactory.CreateClam()
        {
            return new FrozenClam();
        }

        IDough IIngredientsFactory.CreateDough()
        {
            return new ThinCrust();
        }

        ISauce IIngredientsFactory.CreateSauce()
        {
            return new CherryTomato();
        }

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies()
        {
            IVeggies[] arr = { new Olive(), new Onion(), new Pepper() };
            return arr;
        }
    }
}
