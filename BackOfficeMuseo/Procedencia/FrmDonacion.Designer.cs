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
            this.dtpFechaDonacion.Location = new System.Drawing.Point(220, 59);
            this.dtpFechaDonacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDonacion.MaxDate = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            this.dtpFechaDonacion.Name = "dtpFechaDonacion";
            this.dtpFechaDonacion.Size = new System.Drawing.Size(404, 22);
            this.dtpFechaDonacion.TabIndex = 3;
            this.dtpFechaDonacion.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // lblFechaDonacion
            // 
            this.lblFechaDonacion.AutoSize = true;
            this.lblFechaDonacion.Location = new System.Drawing.Point(48, 66);
            this.lblFechaDonacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDonacion.Name = "lblFechaDonacion";
            this.lblFechaDonacion.Size = new System.Drawing.Size(126, 16);
            this.lblFechaDonacion.TabIndex = 2;
            this.lblFechaDonacion.Text = "Fecha de donacion:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(220, 438);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(404, 100);
            this.txtObservaciones.TabIndex = 9;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(76, 438);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(102, 16);
            this.lblObservaciones.TabIndex = 8;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // cbExponer
            // 
            this.cbExponer.AutoSize = true;
            this.cbExponer.Location = new System.Drawing.Point(367, 128);
            this.cbExponer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbExponer.Name = "cbExponer";
            this.cbExponer.Size = new System.Drawing.Size(101, 20);
            this.cbExponer.TabIndex = 10;
            this.cbExponer.Text = "Se expone?";
            this.cbExponer.UseVisualStyleBackColor = true;
            // 
            // cbPrestar
            // 
            this.cbPrestar.AutoSize = true;
            this.cbPrestar.Location = new System.Drawing.Point(220, 128);
            this.cbPrestar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrestar.Name = "cbPrestar";
            this.cbPrestar.Size = new System.Drawing.Size(94, 20);
            this.cbPrestar.TabIndex = 11;
            this.cbPrestar.Text = "Se presta?";
            this.cbPrestar.UseVisualStyleBackColor = true;
            // 
            // cbVender
            // 
            this.cbVender.AutoSize = true;
            this.cbVender.Location = new System.Drawing.Point(521, 128);
            this.cbVender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVender.Name = "cbVender";
            this.cbVender.Size = new System.Drawing.Size(94, 20);
            this.cbVender.TabIndex = 12;
            this.cbVender.Text = "Se vende?";
            this.cbVender.UseVisualStyleBackColor = true;
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Location = new System.Drawing.Point(93, 334);
            this.lblCondiciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(85, 16);
            this.lblCondiciones.TabIndex = 14;
            this.lblCondiciones.Text = "Condiciones:";
            // 
            // txtCondiciones
            // 
            this.txtCondiciones.Location = new System.Drawing.Point(220, 330);
            this.txtCondiciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCondiciones.MaxLength = 500;
            this.txtCondiciones.Multiline = true;
            this.txtCondiciones.Name = "txtCondiciones";
            this.txtCondiciones.Size = new System.Drawing.Size(404, 100);
            this.txtCondiciones.TabIndex = 15;
            // 
            // cboDonante
            // 
            this.cboDonante.FormattingEnabled = true;
            this.cboDonante.Location = new System.Drawing.Point(220, 187);
            this.cboDonante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDonante.Name = "cboDonante";
            this.cboDonante.Size = new System.Drawing.Size(160, 24);
            this.cboDonante.TabIndex = 16;
            this.cboDonante.SelectedIndexChanged += new System.EventHandler(this.cboDonante_SelectedIndexChanged);
            // 
            // lblDonante
            // 
            this.lblDonante.AutoSize = true;
            this.lblDonante.Location = new System.Drawing.Point(116, 191);
            this.lblDonante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonante.Name = "lblDonante";
            this.lblDonante.Size = new System.Drawing.Size(61, 16);
            this.lblDonante.TabIndex = 17;
            this.lblDonante.Text = "Donante:";
            // 
            // lblExposicion
            // 
            this.lblExposicion.AutoSize = true;
            this.lblExposicion.Location = new System.Drawing.Point(53, 257);
            this.lblExposicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExposicion.Name = "lblExposicion";
            this.lblExposicion.Size = new System.Drawing.Size(125, 16);
            this.lblExposicion.TabIndex = 18;
            this.lblExposicion.Text = "Tiempo exposición:";
            // 
            // nudExposicion
            // 
            this.nudExposicion.Location = new System.Drawing.Point(232, 257);
            this.nudExposicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudExposicion.Name = "nudExposicion";
            this.nudExposicion.Size = new System.Drawing.Size(160, 22);
            this.nudExposicion.TabIndex = 19;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(521, 562);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // FrmDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 631);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDonacion";
            this.Text = "DonacionObra";
            this.Load += new System.EventHandler(this.FrmDonacion_Load);
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