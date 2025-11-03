namespace BackOfficeMuseo.Procedencia
{
    partial class CompraObra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Location = new System.Drawing.Point(46, 27);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(93, 13);
            this.lblFechaCompra.TabIndex = 0;
            this.lblFechaCompra.Text = "Fecha de compra:";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Location = new System.Drawing.Point(145, 21);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(304, 20);
            this.dtpFechaCompra.TabIndex = 1;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(94, 68);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 2;
            this.lblImporte.Text = "Importe:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(46, 107);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(273, 68);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(49, 13);
            this.lblMoneda.TabIndex = 4;
            this.lblMoneda.Text = "Moneda:";
            // 
            // nudImporte
            // 
            this.nudImporte.Location = new System.Drawing.Point(145, 65);
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(120, 20);
            this.nudImporte.TabIndex = 5;
            // 
            // cboMoneda
            // 
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Items.AddRange(new object[] {
            "$U",
            "U$D",
            "EUR"});
            this.cboMoneda.Location = new System.Drawing.Point(328, 65);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(121, 21);
            this.cboMoneda.TabIndex = 6;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(133, 104);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(316, 82);
            this.txtObservaciones.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(374, 202);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // CompraObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 254);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.cboMoneda);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.dtpFechaCompra);
            this.Controls.Add(this.lblFechaCompra);
            this.Name = "CompraObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de obra";
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnConfirmar;
    }
}