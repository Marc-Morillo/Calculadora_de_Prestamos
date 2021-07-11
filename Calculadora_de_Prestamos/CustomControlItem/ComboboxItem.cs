using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_de_Prestamos.CustomControlItem
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
