namespace BackOfficeMuseo.Procedencia
{
    partial class FrmDonacion
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
            this.dtpFechaDonacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDonacion = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.chkExponer = new System.Windows.Forms.CheckBox();
            this.chkPrestar = new System.Windows.Forms.CheckBox();
            this.chkVender = new System.Windows.Forms.CheckBox();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.txtCondiciones = new System.Windows.Forms.TextBox();
            this.cboDonante = new System.Windows.Forms.ComboBox();
            this.lblDonante = new System.Windows.Forms.Label();
            this.lblExposicion = new System.Windows.Forms.Label();
            this.nudMeses = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaDonacion
            // 
            this.dtpFechaDonacion.Location = new System.Drawing.Point(165, 48);
            this.dtpFechaDonacion.MaxDate = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            this.dtpFechaDonacion.Name = "dtpFechaDonacion";
            this.dtpFechaDonacion.Size = new System.Drawing.Size(304, 20);
            this.dtpFechaDonacion.TabIndex = 1;
            this.dtpFechaDonacion.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // lblFechaDonacion
            // 
            this.lblFechaDonacion.AutoSize = true;
            this.lblFechaDonacion.Location = new System.Drawing.Point(36, 54);
            this.lblFechaDonacion.Name = "lblFechaDonacion";
            this.lblFechaDonacion.Size = new System.Drawing.Size(102, 13);
            this.lblFechaDonacion.TabIndex = 0;
            this.lblFechaDonacion.Text = "Fecha de donacion:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(165, 356);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(304, 82);
            this.txtObservaciones.TabIndex = 8;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(57, 356);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // chkExponer
            // 
            this.chkExponer.AutoSize = true;
            this.chkExponer.Location = new System.Drawing.Point(346, 210);
            this.chkExponer.Name = "chkExponer";
            this.chkExponer.Size = new System.Drawing.Size(83, 17);
            this.chkExponer.TabIndex = 6;
            this.chkExponer.Text = "Se expone?";
            this.chkExponer.UseVisualStyleBackColor = true;
            // 
            // chkPrestar
            // 
            this.chkPrestar.AutoSize = true;
            this.chkPrestar.Location = new System.Drawing.Point(165, 104);
            this.chkPrestar.Name = "chkPrestar";
            this.chkPrestar.Size = new System.Drawing.Size(77, 17);
            this.chkPrestar.TabIndex = 2;
            this.chkPrestar.Text = "Se presta?";
            this.chkPrestar.UseVisualStyleBackColor = true;
            // 
            // chkVender
            // 
            this.chkVender.AutoSize = true;
            this.chkVender.Location = new System.Drawing.Point(291, 104);
            this.chkVender.Name = "chkVender";
            this.chkVender.Size = new System.Drawing.Size(78, 17);
            this.chkVender.TabIndex = 3;
            this.chkVender.Text = "Se vende?";
            this.chkVender.UseVisualStyleBackColor = true;
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Location = new System.Drawing.Point(70, 271);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(68, 13);
            this.lblCondiciones.TabIndex = 0;
            this.lblCondiciones.Text = "Condiciones:";
            // 
            // txtCondiciones
            // 
            this.txtCondiciones.Location = new System.Drawing.Point(165, 268);
            this.txtCondiciones.MaxLength = 500;
            this.txtCondiciones.Multiline = true;
            this.txtCondiciones.Name = "txtCondiciones";
            this.txtCondiciones.Size = new System.Drawing.Size(304, 82);
            this.txtCondiciones.TabIndex = 7;
            // 
            // cboDonante
            // 
            this.cboDonante.FormattingEnabled = true;
            this.cboDonante.Location = new System.Drawing.Point(165, 152);
            this.cboDonante.Name = "cboDonante";
            this.cboDonante.Size = new System.Drawing.Size(121, 21);
            this.cboDonante.TabIndex = 4;
            this.cboDonante.SelectedIndexChanged += new System.EventHandler(this.cboDonante_SelectedIndexChanged);
            // 
            // lblDonante
            // 
            this.lblDonante.AutoSize = true;
            this.lblDonante.Location = new System.Drawing.Point(87, 155);
            this.lblDonante.Name = "lblDonante";
            this.lblDonante.Size = new System.Drawing.Size(51, 13);
            this.lblDonante.TabIndex = 0;
            this.lblDonante.Text = "Donante:";
            // 
            // lblExposicion
            // 
            this.lblExposicion.AutoSize = true;
            this.lblExposicion.Location = new System.Drawing.Point(40, 209);
            this.lblExposicion.Name = "lblExposicion";
            this.lblExposicion.Size = new System.Drawing.Size(98, 13);
            this.lblExposicion.TabIndex = 0;
            this.lblExposicion.Text = "Tiempo exposición:";
            // 
            // nudMeses
            // 
            this.nudMeses.Location = new System.Drawing.Point(174, 209);
            this.nudMeses.Name = "nudMeses";
            this.nudMeses.Size = new System.Drawing.Size(120, 20);
            this.nudMeses.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(391, 457);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // FrmDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 513);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.nudMeses);
            this.Controls.Add(this.lblExposicion);
            this.Controls.Add(this.lblDonante);
            this.Controls.Add(this.cboDonante);
            this.Controls.Add(this.txtCondiciones);
            this.Controls.Add(this.lblCondiciones);
            this.Controls.Add(this.chkVender);
            this.Controls.Add(this.chkPrestar);
            this.Controls.Add(this.chkExponer);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.dtpFechaDonacion);
            this.Controls.Add(this.lblFechaDonacion);
            this.Name = "FrmDonacion";
            this.Text = "DonacionObra";
            this.Load += new System.EventHandler(this.FrmDonacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMeses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDonacion;
        private System.Windows.Forms.Label lblFechaDonacion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.CheckBox chkExponer;
        private System.Windows.Forms.CheckBox chkPrestar;
        private System.Windows.Forms.CheckBox chkVender;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.TextBox txtCondiciones;
        private System.Windows.Forms.ComboBox cboDonante;
        private System.Windows.Forms.Label lblDonante;
        private System.Windows.Forms.Label lblExposicion;
        private System.Windows.Forms.NumericUpDown nudMeses;
        private System.Windows.Forms.Button btnConfirmar;
    }
}