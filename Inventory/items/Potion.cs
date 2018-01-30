using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Inventory.items
{
    class Potion : AItem
    {
        public int Health;
        public int Stamina;
        public Potion(Point souradnice, string typ) : base(souradnice, typ)
        {

        }
    }
}
