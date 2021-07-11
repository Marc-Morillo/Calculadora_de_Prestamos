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
    }
}
