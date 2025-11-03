namespace BackOfficeMuseo.Procedencia
{
    partial class PrestamoObra
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.lblDetallesSeguro = new System.Windows.Forms.Label();
            this.cbSeguro = new System.Windows.Forms.CheckBox();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.cbPersona = new System.Windows.Forms.ComboBox();
            this.cbInstitucion = new System.Windows.Forms.ComboBox();
            this.txtDetallesSeguro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(402, 409);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(144, 149);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(220, 82);
            this.txtObservaciones.TabIndex = 22;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(48, 149);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 21;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(394, 98);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(49, 13);
            this.lblPersona.TabIndex = 24;
            this.lblPersona.Text = "Persona:";
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Location = new System.Drawing.Point(576, 98);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(58, 13);
            this.lblInstitucion.TabIndex = 25;
            this.lblInstitucion.Text = "Institucion:";
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.AutoSize = true;
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(437, 58);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(95, 13);
            this.lblFechaFinalizacion.TabIndex = 26;
            this.lblFechaFinalizacion.Text = "Fecha finalizacion:";
            // 
            // lblDetallesSeguro
            // 
            this.lblDetallesSeguro.AutoSize = true;
            this.lblDetallesSeguro.Location = new System.Drawing.Point(48, 98);
            this.lblDetallesSeguro.Name = "lblDetallesSeguro";
            this.lblDetallesSeguro.Size = new System.Drawing.Size(83, 13);
            this.lblDetallesSeguro.TabIndex = 27;
            this.lblDetallesSeguro.Text = "Detalles seguro:";
            // 
            // cbSeguro
            // 
            this.cbSeguro.AutoSize = true;
            this.cbSeguro.Location = new System.Drawing.Point(667, 151);
            this.cbSeguro.Name = "cbSeguro";
            this.cbSeguro.Size = new System.Drawing.Size(94, 17);
            this.cbSeguro.TabIndex = 28;
            this.cbSeguro.Text = "Tiene seguro?";
            this.cbSeguro.UseVisualStyleBackColor = true;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(39, 59);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(101, 13);
            this.lblFechaPrestamo.TabIndex = 29;
            this.lblFechaPrestamo.Text = "Fecha de préstamo:";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(144, 53);
            this.dtpFechaPrestamo.MaxDate = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPrestamo.TabIndex = 30;
            this.dtpFechaPrestamo.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // dtpFechaFinalizacion
            // 
            this.dtpFechaFinalizacion.Location = new System.Drawing.Point(561, 52);
            this.dtpFechaFinalizacion.MaxDate = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            this.dtpFechaFinalizacion.Name = "dtpFechaFinalizacion";
            this.dtpFechaFinalizacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinalizacion.TabIndex = 31;
            this.dtpFechaFinalizacion.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // cbPersona
            // 
            this.cbPersona.FormattingEnabled = true;
            this.cbPersona.Location = new System.Drawing.Point(449, 95);
            this.cbPersona.Name = "cbPersona";
            this.cbPersona.Size = new System.Drawing.Size(121, 21);
            this.cbPersona.TabIndex = 32;
            // 
            // cbInstitucion
            // 
            this.cbInstitucion.FormattingEnabled = true;
            this.cbInstitucion.Location = new System.Drawing.Point(640, 95);
            this.cbInstitucion.Name = "cbInstitucion";
            this.cbInstitucion.Size = new System.Drawing.Size(121, 21);
            this.cbInstitucion.TabIndex = 33;
            // 
            // txtDetallesSeguro
            // 
            this.txtDetallesSeguro.Location = new System.Drawing.Point(144, 98);
            this.txtDetallesSeguro.MaxLength = 500;
            this.txtDetallesSeguro.Multiline = true;
            this.txtDetallesSeguro.Name = "txtDetallesSeguro";
            this.txtDetallesSeguro.Size = new System.Drawing.Size(220, 24);
            this.txtDetallesSeguro.TabIndex = 34;
            // 
            // PrestamoObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDetallesSeguro);
            this.Controls.Add(this.cbInstitucion);
            this.Controls.Add(this.cbPersona);
            this.Controls.Add(this.dtpFechaFinalizacion);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.cbSeguro);
            this.Controls.Add(this.lblDetallesSeguro);
            this.Controls.Add(this.lblFechaFinalizacion);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Name = "PrestamoObra";
            this.Text = "PrestamoObra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private System.Windows.Forms.Label lblDetallesSeguro;
        private System.Windows.Forms.CheckBox cbSeguro;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalizacion;
        private System.Windows.Forms.ComboBox cbPersona;
        private System.Windows.Forms.ComboBox cbInstitucion;
        private System.Windows.Forms.TextBox txtDetallesSeguro;
    }
}