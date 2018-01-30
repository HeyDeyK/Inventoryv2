using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Inventory.items
{
    class Food : AItem
    {
        public int Health;
        public int Stamina;
        public Food(Point souradnice, string typ) : base(souradnice, typ)
        {

        }
    }
}
