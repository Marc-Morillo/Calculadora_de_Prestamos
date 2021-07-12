using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_de_Prestamos.CustomControlItem;
using Calculadora_de_Prestamos.CustomControlItem2;

namespace Calculadora_de_Prestamos
{
    public partial class FrmConvertidor : Form
    {
        public FrmConvertidor()
        {
            InitializeComponent();
        }

        private void FrmConvertidor_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadCombobox2();
        }

        private void LoadCombobox()
        {
            ComboboxItem Opcionpordefecto = new ComboboxItem();
            Opcionpordefecto.Text = "Por favor seleccione una opcion";
            Opcionpordefecto.Value = null;

            ComboboxItem OpcionPersonal = new ComboboxItem();
            OpcionPersonal.Text = "Personal";
            OpcionPersonal.Value = 1;

            ComboboxItem OpcionAutomovil = new ComboboxItem();
            OpcionAutomovil.Text = "Automóvil";
            OpcionAutomovil.Value = 2;

            ComboboxItem OpcionHipotecario = new ComboboxItem();
            OpcionHipotecario.Text = "Hipotecario";
            OpcionHipotecario.Value = 3;

            CbxTipoPrestamo.Items.Add(Opcionpordefecto);
            CbxTipoPrestamo.Items.Add(OpcionPersonal);
            CbxTipoPrestamo.Items.Add(OpcionAutomovil);
            CbxTipoPrestamo.Items.Add(OpcionHipotecario);
            CbxTipoPrestamo.SelectedItem = Opcionpordefecto;
        }

        private void LoadCombobox2()
        {
            ComboboxItem2 OpcionDefecto = new ComboboxItem2();
            OpcionDefecto.Text = "Por favor seleccione una opcion";
            OpcionDefecto.Value = null;

            ComboboxItem2 Mes1 = new ComboboxItem2();
            Mes1.Text = "12";
            Mes1.Value = 1;

            ComboboxItem2 Mes2 = new ComboboxItem2();
            Mes2.Text = "18";
            Mes2.Value = 2;

            ComboboxItem2 Mes3 = new ComboboxItem2();
            Mes3.Text = "24";
            Mes3.Value = 3;

            ComboboxItem2 Mes4 = new ComboboxItem2();
            Mes4.Text = "30";
            Mes4.Value = 4;

            ComboboxItem2 Mes5 = new ComboboxItem2();
            Mes5.Text = "36";
            Mes5.Value = 5;

            ComboboxItem2 Mes6 = new ComboboxItem2();
            Mes6.Text = "42";
            Mes6.Value = 6;

            ComboboxItem2 Mes7 = new ComboboxItem2();
            Mes7.Text = "48";
            Mes7.Value = 7;

            ComboboxItem2 Mes8 = new ComboboxItem2();
            Mes8.Text = "54";
            Mes8.Value = 8;

            ComboboxItem2 Mes9 = new ComboboxItem2();
            Mes9.Text = "60";
            Mes9.Value = 9;

            ComboboxItem2 Mes10 = new ComboboxItem2();
            Mes10.Text = "66";
            Mes10.Value = 10;

            ComboboxItem2 Mes11 = new ComboboxItem2();
            Mes11.Text = "72";
            Mes11.Value = 11;

            ComboboxItem2 Mes12 = new ComboboxItem2();
            Mes12.Text = "78";
            Mes12.Value = 12;

            ComboboxItem2 Mes13 = new ComboboxItem2();
            Mes13.Text = "84";
            Mes13.Value = 13;

            ComboboxItem2 Mes14 = new ComboboxItem2();
            Mes14.Text = "90";
            Mes14.Value = 14;

            ComboboxItem2 Mes15 = new ComboboxItem2();
            Mes15.Text = "96";
            Mes15.Value = 15;

            ComboboxItem2 Mes16 = new ComboboxItem2();
            Mes16.Text = "102";
            Mes16.Value = 16;

            ComboboxItem2 Mes17 = new ComboboxItem2();
            Mes17.Text = "108";
            Mes17.Value = 17;

            ComboboxItem2 Mes18 = new ComboboxItem2();
            Mes18.Text = "114";
            Mes18.Value = 18;

            ComboboxItem2 Mes19 = new ComboboxItem2();
            Mes19.Text = "120";
            Mes19.Value = 19;

            CbxCantidadCuotas.Items.Add(OpcionDefecto);
            CbxCantidadCuotas.Items.Add(Mes1);
            CbxCantidadCuotas.Items.Add(Mes2);
            CbxCantidadCuotas.Items.Add(Mes3);
            CbxCantidadCuotas.Items.Add(Mes4);
            CbxCantidadCuotas.Items.Add(Mes5);
            CbxCantidadCuotas.Items.Add(Mes6);
            CbxCantidadCuotas.Items.Add(Mes7);
            CbxCantidadCuotas.Items.Add(Mes8);
            CbxCantidadCuotas.Items.Add(Mes9);
            CbxCantidadCuotas.Items.Add(Mes10);
            CbxCantidadCuotas.Items.Add(Mes11);
            CbxCantidadCuotas.Items.Add(Mes12);
            CbxCantidadCuotas.Items.Add(Mes13);
            CbxCantidadCuotas.Items.Add(Mes14);
            CbxCantidadCuotas.Items.Add(Mes15);
            CbxCantidadCuotas.Items.Add(Mes16);
            CbxCantidadCuotas.Items.Add(Mes17);
            CbxCantidadCuotas.Items.Add(Mes18);
            CbxCantidadCuotas.Items.Add(Mes19);
            CbxCantidadCuotas.SelectedItem = OpcionDefecto;

        }
        private void lblCuotasMensuales_Click(object sender, EventArgs e)
        {

        }

        private void lblInteresMensual_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CbxTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
