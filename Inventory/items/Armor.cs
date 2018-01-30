using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Inventory.items
{
    class Armor : AItem
    {
        public int Defense;
        public Armor(Point souradnice, string typ) : base(souradnice, typ)
        {

        }
    }
}
