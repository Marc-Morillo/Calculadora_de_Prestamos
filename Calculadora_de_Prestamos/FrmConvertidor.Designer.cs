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
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTipodePrestamo = new System.Windows.Forms.Label();
            this.CbxTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.TxtTasa = new System.Windows.Forms.TextBox();
            this.CbxCantidadCuotas = new System.Windows.Forms.ComboBox();
            this.TxtResultadoCuota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMontodelPrestamo
            // 
            this.lblMontodelPrestamo.AutoSize = true;
            this.lblMontodelPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMontodelPrestamo.Location = new System.Drawing.Point(41, 149);
            this.lblMontodelPrestamo.Name = "lblMontodelPrestamo";
            this.lblMontodelPrestamo.Size = new System.Drawing.Size(320, 45);
            this.lblMontodelPrestamo.TabIndex = 0;
            this.lblMontodelPrestamo.Text = "Monto del préstamo:";
            // 
            // lblCuotasMensuales
            // 
            this.lblCuotasMensuales.AutoSize = true;
            this.lblCuotasMensuales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuotasMensuales.Location = new System.Drawing.Point(41, 342);
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
            this.lblInteresMensual.Location = new System.Drawing.Point(41, 277);
            this.lblInteresMensual.Name = "lblInteresMensual";
            this.lblInteresMensual.Size = new System.Drawing.Size(419, 45);
            this.lblInteresMensual.TabIndex = 0;
            this.lblInteresMensual.Text = "Tasa de intéres mensual (%):";
            this.lblInteresMensual.Click += new System.EventHandler(this.lblInteresMensual_Click);
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuotaMensual.Location = new System.Drawing.Point(41, 478);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(239, 45);
            this.lblCuotaMensual.TabIndex = 0;
            this.lblCuotaMensual.Text = "Cuota mensual:";
            this.lblCuotaMensual.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 39);
            this.textBox1.TabIndex = 1;
            // 
            // lblTipodePrestamo
            // 
            this.lblTipodePrestamo.AutoSize = true;
            this.lblTipodePrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipodePrestamo.Location = new System.Drawing.Point(41, 215);
            this.lblTipodePrestamo.Name = "lblTipodePrestamo";
            this.lblTipodePrestamo.Size = new System.Drawing.Size(279, 45);
            this.lblTipodePrestamo.TabIndex = 0;
            this.lblTipodePrestamo.Text = "Tipo de prestamo:";
            // 
            // CbxTipoPrestamo
            // 
            this.CbxTipoPrestamo.FormattingEnabled = true;
            this.CbxTipoPrestamo.Location = new System.Drawing.Point(326, 215);
            this.CbxTipoPrestamo.Name = "CbxTipoPrestamo";
            this.CbxTipoPrestamo.Size = new System.Drawing.Size(334, 40);
            this.CbxTipoPrestamo.TabIndex = 3;
            // 
            // TxtTasa
            // 
            this.TxtTasa.Location = new System.Drawing.Point(466, 283);
            this.TxtTasa.Name = "TxtTasa";
            this.TxtTasa.ReadOnly = true;
            this.TxtTasa.Size = new System.Drawing.Size(194, 39);
            this.TxtTasa.TabIndex = 4;
            // 
            // CbxCantidadCuotas
            // 
            this.CbxCantidadCuotas.FormattingEnabled = true;
            this.CbxCantidadCuotas.Location = new System.Drawing.Point(507, 349);
            this.CbxCantidadCuotas.Name = "CbxCantidadCuotas";
            this.CbxCantidadCuotas.Size = new System.Drawing.Size(153, 40);
            this.CbxCantidadCuotas.TabIndex = 3;
            // 
            // TxtResultadoCuota
            // 
            this.TxtResultadoCuota.Location = new System.Drawing.Point(286, 484);
            this.TxtResultadoCuota.Name = "TxtResultadoCuota";
            this.TxtResultadoCuota.ReadOnly = true;
            this.TxtResultadoCuota.Size = new System.Drawing.Size(174, 39);
            this.TxtResultadoCuota.TabIndex = 5;
            // 
            // FrmConvertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 617);
            this.Controls.Add(this.TxtResultadoCuota);
            this.Controls.Add(this.CbxCantidadCuotas);
            this.Controls.Add(this.TxtTasa);
            this.Controls.Add(this.CbxTipoPrestamo);
            this.Controls.Add(this.lblTipodePrestamo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.lblInteresMensual);
            this.Controls.Add(this.lblCuotasMensuales);
            this.Controls.Add(this.lblMontodelPrestamo);
            this.Name = "FrmConvertidor";
            this.Text = "Calculadora de Prestamos";
            this.Load += new System.EventHandler(this.FrmConvertidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontodelPrestamo;
        private System.Windows.Forms.Label lblCuotasMensuales;
        private System.Windows.Forms.Label lblInteresMensual;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTipodePrestamo;
        private System.Windows.Forms.ComboBox CbxTipoPrestamo;
        private System.Windows.Forms.TextBox TxtTasa;
        private System.Windows.Forms.ComboBox CbxCantidadCuotas;
        private System.Windows.Forms.TextBox TxtResultadoCuota;
    }
}

