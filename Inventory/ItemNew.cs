using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHelpers;
using System.Threading.Tasks;
using System.Windows;

namespace Inventory
{
    [DelimitedRecord("|")]
    class ItemNew
    {
        public Point Souradnice;
        public string Typ;

    }
}
