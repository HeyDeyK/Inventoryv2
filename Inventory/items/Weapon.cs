using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Inventory.items
{
    class Weapon : AItem
    {
        public int Damage;
        public int Speed;
        public Weapon(Point souradnice, string typ) : base(souradnice, typ)
        {

        }
    }
}
