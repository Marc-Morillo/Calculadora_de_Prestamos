using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_de_Prestamos.CustomControlItem2
{
    public class ComboboxItem2
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
