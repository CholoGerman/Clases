namespace BackOfficeMuseo.Procedencia
{
    partial class DonacionObra
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
            this.cbExponer = new System.Windows.Forms.CheckBox();
            this.cbPrestar = new System.Windows.Forms.CheckBox();
            this.cbVender = new System.Windows.Forms.CheckBox();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.txtCondiciones = new System.Windows.Forms.TextBox();
            this.cboDonante = new System.Windows.Forms.ComboBox();
            this.lblDonante = new System.Windows.Forms.Label();
            this.lblExposicion = new System.Windows.Forms.Label();
            this.nudExposicion = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposicion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaDonacion
            // 
            this.dtpFechaDonacion.Location = new System.Drawing.Point(165, 48);
            this.dtpFechaDonacion.MaxDate = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            this.dtpFechaDonacion.Name = "dtpFechaDonacion";
            this.dtpFechaDonacion.Size = new System.Drawing.Size(304, 20);
            this.dtpFechaDonacion.TabIndex = 3;
            this.dtpFechaDonacion.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // lblFechaDonacion
            // 
            this.lblFechaDonacion.AutoSize = true;
            this.lblFechaDonacion.Location = new System.Drawing.Point(36, 54);
            this.lblFechaDonacion.Name = "lblFechaDonacion";
            this.lblFechaDonacion.Size = new System.Drawing.Size(102, 13);
            this.lblFechaDonacion.TabIndex = 2;
            this.lblFechaDonacion.Text = "Fecha de donacion:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(165, 356);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(304, 82);
            this.txtObservaciones.TabIndex = 9;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(57, 356);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 8;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // cbExponer
            // 
            this.cbExponer.AutoSize = true;
            this.cbExponer.Location = new System.Drawing.Point(275, 104);
            this.cbExponer.Name = "cbExponer";
            this.cbExponer.Size = new System.Drawing.Size(83, 17);
            this.cbExponer.TabIndex = 10;
            this.cbExponer.Text = "Se expone?";
            this.cbExponer.UseVisualStyleBackColor = true;
            // 
            // cbPrestar
            // 
            this.cbPrestar.AutoSize = true;
            this.cbPrestar.Location = new System.Drawing.Point(165, 104);
            this.cbPrestar.Name = "cbPrestar";
            this.cbPrestar.Size = new System.Drawing.Size(77, 17);
            this.cbPrestar.TabIndex = 11;
            this.cbPrestar.Text = "Se presta?";
            this.cbPrestar.UseVisualStyleBackColor = true;
            // 
            // cbVender
            // 
            this.cbVender.AutoSize = true;
            this.cbVender.Location = new System.Drawing.Point(391, 104);
            this.cbVender.Name = "cbVender";
            this.cbVender.Size = new System.Drawing.Size(78, 17);
            this.cbVender.TabIndex = 12;
            this.cbVender.Text = "Se vende?";
            this.cbVender.UseVisualStyleBackColor = true;
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Location = new System.Drawing.Point(70, 271);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(68, 13);
            this.lblCondiciones.TabIndex = 14;
            this.lblCondiciones.Text = "Condiciones:";
            // 
            // txtCondiciones
            // 
            this.txtCondiciones.Location = new System.Drawing.Point(165, 268);
            this.txtCondiciones.MaxLength = 500;
            this.txtCondiciones.Multiline = true;
            this.txtCondiciones.Name = "txtCondiciones";
            this.txtCondiciones.Size = new System.Drawing.Size(304, 82);
            this.txtCondiciones.TabIndex = 15;
            // 
            // cboDonante
            // 
            this.cboDonante.FormattingEnabled = true;
            this.cboDonante.Location = new System.Drawing.Point(165, 152);
            this.cboDonante.Name = "cboDonante";
            this.cboDonante.Size = new System.Drawing.Size(121, 21);
            this.cboDonante.TabIndex = 16;
            // 
            // lblDonante
            // 
            this.lblDonante.AutoSize = true;
            this.lblDonante.Location = new System.Drawing.Point(87, 155);
            this.lblDonante.Name = "lblDonante";
            this.lblDonante.Size = new System.Drawing.Size(51, 13);
            this.lblDonante.TabIndex = 17;
            this.lblDonante.Text = "Donante:";
            // 
            // lblExposicion
            // 
            this.lblExposicion.AutoSize = true;
            this.lblExposicion.Location = new System.Drawing.Point(40, 209);
            this.lblExposicion.Name = "lblExposicion";
            this.lblExposicion.Size = new System.Drawing.Size(98, 13);
            this.lblExposicion.TabIndex = 18;
            this.lblExposicion.Text = "Tiempo exposición:";
            // 
            // nudExposicion
            // 
            this.nudExposicion.Location = new System.Drawing.Point(174, 209);
            this.nudExposicion.Name = "nudExposicion";
            this.nudExposicion.Size = new System.Drawing.Size(120, 20);
            this.nudExposicion.TabIndex = 19;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(391, 457);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // DonacionObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 513);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.nudExposicion);
            this.Controls.Add(this.lblExposicion);
            this.Controls.Add(this.lblDonante);
            this.Controls.Add(this.cboDonante);
            this.Controls.Add(this.txtCondiciones);
            this.Controls.Add(this.lblCondiciones);
            this.Controls.Add(this.cbVender);
            this.Controls.Add(this.cbPrestar);
            this.Controls.Add(this.cbExponer);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.dtpFechaDonacion);
            this.Controls.Add(this.lblFechaDonacion);
            this.Name = "DonacionObra";
            this.Text = "DonacionObra";
            ((System.ComponentModel.ISupportInitialize)(this.nudExposicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDonacion;
        private System.Windows.Forms.Label lblFechaDonacion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.CheckBox cbExponer;
        private System.Windows.Forms.CheckBox cbPrestar;
        private System.Windows.Forms.CheckBox cbVender;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.TextBox txtCondiciones;
        private System.Windows.Forms.ComboBox cboDonante;
        private System.Windows.Forms.Label lblDonante;
        private System.Windows.Forms.Label lblExposicion;
        private System.Windows.Forms.NumericUpDown nudExposicion;
        private System.Windows.Forms.Button btnConfirmar;
    }
}