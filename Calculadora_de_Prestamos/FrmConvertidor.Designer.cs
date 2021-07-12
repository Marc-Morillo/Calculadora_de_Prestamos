namespace Calculadora_de_Prestamos
{
    partial class FrmConvertidor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMontodelPrestamo = new System.Windows.Forms.Label();
            this.lblCuotasMensuales = new System.Windows.Forms.Label();
            this.lblInteresMensual = new System.Windows.Forms.Label();
            this.TxtPrestamo = new System.Windows.Forms.TextBox();
            this.lblTipodePrestamo = new System.Windows.Forms.Label();
            this.CbxTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.TxtTasa = new System.Windows.Forms.TextBox();
            this.CbxCantidadCuotas = new System.Windows.Forms.ComboBox();
            this.TxtResultadoCuota = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.lblCuotaResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMontodelPrestamo
            // 
            this.lblMontodelPrestamo.AutoSize = true;
            this.lblMontodelPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMontodelPrestamo.Location = new System.Drawing.Point(140, 66);
            this.lblMontodelPrestamo.Name = "lblMontodelPrestamo";
            this.lblMontodelPrestamo.Size = new System.Drawing.Size(320, 45);
            this.lblMontodelPrestamo.TabIndex = 0;
            this.lblMontodelPrestamo.Text = "Monto del préstamo:";
            // 
            // lblCuotasMensuales
            // 
            this.lblCuotasMensuales.AutoSize = true;
            this.lblCuotasMensuales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuotasMensuales.Location = new System.Drawing.Point(12, 246);
            this.lblCuotasMensuales.Name = "lblCuotasMensuales";
            this.lblCuotasMensuales.Size = new System.Drawing.Size(460, 45);
            this.lblCuotasMensuales.TabIndex = 0;
            this.lblCuotasMensuales.Text = "Cantidad de cuotas mensuales:";
            this.lblCuotasMensuales.Click += new System.EventHandler(this.lblCuotasMensuales_Click);
            // 
            // lblInteresMensual
            // 
            this.lblInteresMensual.AutoSize = true;
            this.lblInteresMensual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInteresMensual.Location = new System.Drawing.Point(41, 187);
            this.lblInteresMensual.Name = "lblInteresMensual";
            this.lblInteresMensual.Size = new System.Drawing.Size(419, 45);
            this.lblInteresMensual.TabIndex = 0;
            this.lblInteresMensual.Text = "Tasa de intéres mensual (%):";
            this.lblInteresMensual.Click += new System.EventHandler(this.lblInteresMensual_Click);
            // 
            // TxtPrestamo
            // 
            this.TxtPrestamo.Location = new System.Drawing.Point(466, 72);
            this.TxtPrestamo.Name = "TxtPrestamo";
            this.TxtPrestamo.Size = new System.Drawing.Size(457, 39);
            this.TxtPrestamo.TabIndex = 1;
            // 
            // lblTipodePrestamo
            // 
            this.lblTipodePrestamo.AutoSize = true;
            this.lblTipodePrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipodePrestamo.Location = new System.Drawing.Point(181, 127);
            this.lblTipodePrestamo.Name = "lblTipodePrestamo";
            this.lblTipodePrestamo.Size = new System.Drawing.Size(279, 45);
            this.lblTipodePrestamo.TabIndex = 0;
            this.lblTipodePrestamo.Text = "Tipo de prestamo:";
            // 
            // CbxTipoPrestamo
            // 
            this.CbxTipoPrestamo.FormattingEnabled = true;
            this.CbxTipoPrestamo.Location = new System.Drawing.Point(466, 132);
            this.CbxTipoPrestamo.Name = "CbxTipoPrestamo";
            this.CbxTipoPrestamo.Size = new System.Drawing.Size(457, 40);
            this.CbxTipoPrestamo.TabIndex = 3;
            this.CbxTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.CbxTipoPrestamo_SelectedIndexChanged);
            // 
            // TxtTasa
            // 
            this.TxtTasa.Location = new System.Drawing.Point(466, 193);
            this.TxtTasa.Name = "TxtTasa";
            this.TxtTasa.ReadOnly = true;
            this.TxtTasa.Size = new System.Drawing.Size(457, 39);
            this.TxtTasa.TabIndex = 4;
            // 
            // CbxCantidadCuotas
            // 
            this.CbxCantidadCuotas.FormattingEnabled = true;
            this.CbxCantidadCuotas.Location = new System.Drawing.Point(466, 251);
            this.CbxCantidadCuotas.Name = "CbxCantidadCuotas";
            this.CbxCantidadCuotas.Size = new System.Drawing.Size(457, 40);
            this.CbxCantidadCuotas.TabIndex = 3;
            // 
            // TxtResultadoCuota
            // 
            this.TxtResultadoCuota.Location = new System.Drawing.Point(466, 311);
            this.TxtResultadoCuota.Name = "TxtResultadoCuota";
            this.TxtResultadoCuota.ReadOnly = true;
            this.TxtResultadoCuota.Size = new System.Drawing.Size(457, 39);
            this.TxtResultadoCuota.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(711, 400);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(212, 89);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblCuotaResultado
            // 
            this.lblCuotaResultado.AutoSize = true;
            this.lblCuotaResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuotaResultado.Location = new System.Drawing.Point(183, 305);
            this.lblCuotaResultado.Name = "lblCuotaResultado";
            this.lblCuotaResultado.Size = new System.Drawing.Size(277, 45);
            this.lblCuotaResultado.TabIndex = 0;
            this.lblCuotaResultado.Text = "Cuotas mensuales";
            this.lblCuotaResultado.Click += new System.EventHandler(this.lblCuotasMensuales_Click);
            // 
            // FrmConvertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 582);
            this.Controls.Add(this.lblCuotaResultado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtResultadoCuota);
            this.Controls.Add(this.CbxCantidadCuotas);
            this.Controls.Add(this.TxtTasa);
            this.Controls.Add(this.CbxTipoPrestamo);
            this.Controls.Add(this.lblTipodePrestamo);
            this.Controls.Add(this.TxtPrestamo);
            this.Controls.Add(this.lblInteresMensual);
            this.Controls.Add(this.lblCuotasMensuales);
            this.Controls.Add(this.lblMontodelPrestamo);
            this.Name = "FrmConvertidor";
            this.Text = " Calculadora de Prestamos Personales";
            this.Load += new System.EventHandler(this.FrmConvertidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontodelPrestamo;
        private System.Windows.Forms.Label lblCuotasMensuales;
        private System.Windows.Forms.Label lblInteresMensual;
        private System.Windows.Forms.TextBox TxtPrestamo;
        private System.Windows.Forms.Label lblTipodePrestamo;
        private System.Windows.Forms.ComboBox CbxTipoPrestamo;
        private System.Windows.Forms.TextBox TxtTasa;
        private System.Windows.Forms.ComboBox CbxCantidadCuotas;
        private System.Windows.Forms.TextBox TxtResultadoCuota;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label lblCuotaResultado;
    }
}

