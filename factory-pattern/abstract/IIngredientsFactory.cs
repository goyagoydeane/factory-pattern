using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    interface IIngredientsFactory
    {
        IDough CreateDough();
        IEnumerable<IVeggies> CreateVeggies();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClam CreateClam();
    }
}
