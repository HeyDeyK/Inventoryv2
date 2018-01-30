using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Inventory.items
{
    abstract class AItem
    {
        public Point Souradnice;
        public string Typ;

        protected AItem(Point souradnice, string typ)
        {
            Souradnice = souradnice;
            Typ = typ;
        }
    }
}
