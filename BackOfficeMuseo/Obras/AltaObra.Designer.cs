namespace BackOfficeMuseo.Obras
{
    partial class AltaObra
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutores = new System.Windows.Forms.Label();
            this.clbAutores = new System.Windows.Forms.CheckedListBox();
            this.lblCreacion = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.lblEpoca = new System.Windows.Forms.Label();
            this.cboProcedencia = new System.Windows.Forms.ComboBox();
            this.cbEpoca = new System.Windows.Forms.ComboBox();
            this.chkEsCopia = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSeleccionarAutor = new System.Windows.Forms.Button();
            this.lblErrorTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(42, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(182, 22);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(235, 20);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Location = new System.Drawing.Point(42, 66);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(46, 13);
            this.lblAutores.TabIndex = 2;
            this.lblAutores.Text = "Autores:";
            // 
            // clbAutores
            // 
            this.clbAutores.FormattingEnabled = true;
            this.clbAutores.Location = new System.Drawing.Point(182, 66);
            this.clbAutores.Name = "clbAutores";
            this.clbAutores.Size = new System.Drawing.Size(235, 79);
            this.clbAutores.TabIndex = 3;
            // 
            // lblCreacion
            // 
            this.lblCreacion.AutoSize = true;
            this.lblCreacion.Location = new System.Drawing.Point(42, 172);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(99, 13);
            this.lblCreacion.TabIndex = 4;
            this.lblCreacion.Text = "Fecha de creacion:";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Location = new System.Drawing.Point(182, 172);
            this.dtpFechaCreacion.MaxDate = new System.DateTime(2025, 10, 22, 11, 9, 41, 0);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCreacion.TabIndex = 6;
            this.dtpFechaCreacion.Value = new System.DateTime(2025, 10, 22, 0, 0, 0, 0);
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(42, 206);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(112, 13);
            this.lblFechaPublicacion.TabIndex = 6;
            this.lblFechaPublicacion.Text = "Fecha de publicacion:";
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(182, 206);
            this.dtpFechaPublicacion.MaxDate = new System.DateTime(2025, 10, 22, 0, 0, 0, 0);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPublicacion.TabIndex = 7;
            this.dtpFechaPublicacion.Value = new System.DateTime(2025, 10, 22, 0, 0, 0, 0);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(45, 265);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(182, 265);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(235, 69);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.AutoSize = true;
            this.lblProcedencia.Location = new System.Drawing.Point(467, 25);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(70, 13);
            this.lblProcedencia.TabIndex = 10;
            this.lblProcedencia.Text = "Procedencia:";
            // 
            // lblEpoca
            // 
            this.lblEpoca.AutoSize = true;
            this.lblEpoca.Location = new System.Drawing.Point(467, 66);
            this.lblEpoca.Name = "lblEpoca";
            this.lblEpoca.Size = new System.Drawing.Size(41, 13);
            this.lblEpoca.TabIndex = 11;
            this.lblEpoca.Text = "Epoca:";
            // 
            // cboProcedencia
            // 
            this.cboProcedencia.FormattingEnabled = true;
            this.cboProcedencia.Items.AddRange(new object[] {
            "Compra",
            "Donacion",
            "Prestamo"});
            this.cboProcedencia.Location = new System.Drawing.Point(576, 22);
            this.cboProcedencia.Name = "cboProcedencia";
            this.cboProcedencia.Size = new System.Drawing.Size(154, 21);
            this.cboProcedencia.TabIndex = 2;
            this.cboProcedencia.SelectedIndexChanged += new System.EventHandler(this.cboProcedencia_SelectedIndexChanged);
            // 
            // cbEpoca
            // 
            this.cbEpoca.FormattingEnabled = true;
            this.cbEpoca.Items.AddRange(new object[] {
            "   Desconocido",
            "   Prehistorico",
            "   Antiguo",
            "   Medieval",
            "   Renacimiento",
            "   Barroco",
            "   Neoclasico",
            "   Romanticismo",
            "   Moderno",
            "   Contemporaneo"});
            this.cbEpoca.Location = new System.Drawing.Point(576, 66);
            this.cbEpoca.Name = "cbEpoca";
            this.cbEpoca.Size = new System.Drawing.Size(154, 21);
            this.cbEpoca.TabIndex = 4;
            this.cbEpoca.SelectedIndexChanged += new System.EventHandler(this.cbEpoca_SelectedIndexChanged);
            // 
            // chkEsCopia
            // 
            this.chkEsCopia.AutoSize = true;
            this.chkEsCopia.Location = new System.Drawing.Point(652, 128);
            this.chkEsCopia.Name = "chkEsCopia";
            this.chkEsCopia.Size = new System.Drawing.Size(78, 17);
            this.chkEsCopia.TabIndex = 5;
            this.chkEsCopia.Text = "Es replica?";
            this.chkEsCopia.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(652, 303);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(87, 31);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSeleccionarAutor
            // 
            this.btnSeleccionarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionarAutor.Location = new System.Drawing.Point(421, 114);
            this.btnSeleccionarAutor.Name = "btnSeleccionarAutor";
            this.btnSeleccionarAutor.Size = new System.Drawing.Size(116, 31);
            this.btnSeleccionarAutor.TabIndex = 5;
            this.btnSeleccionarAutor.Text = "Seleccionar...";
            this.btnSeleccionarAutor.UseVisualStyleBackColor = true;
            this.btnSeleccionarAutor.Click += new System.EventHandler(this.btnSeleccionarAutor_Click);
            // 
            // lblErrorTitulo
            // 
            this.lblErrorTitulo.AutoSize = true;
            this.lblErrorTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitulo.Location = new System.Drawing.Point(45, 38);
            this.lblErrorTitulo.Name = "lblErrorTitulo";
            this.lblErrorTitulo.Size = new System.Drawing.Size(11, 13);
            this.lblErrorTitulo.TabIndex = 12;
            this.lblErrorTitulo.Text = "*";
            this.lblErrorTitulo.Visible = false;
            // 
            // AltaObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorTitulo);
            this.Controls.Add(this.btnSeleccionarAutor);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.chkEsCopia);
            this.Controls.Add(this.cbEpoca);
            this.Controls.Add(this.cboProcedencia);
            this.Controls.Add(this.lblEpoca);
            this.Controls.Add(this.lblProcedencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dtpFechaPublicacion);
            this.Controls.Add(this.lblFechaPublicacion);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.lblCreacion);
            this.Controls.Add(this.clbAutores);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AltaObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de obra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.CheckedListBox clbAutores;
        private System.Windows.Forms.Label lblCreacion;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblProcedencia;
        private System.Windows.Forms.Label lblEpoca;
        private System.Windows.Forms.ComboBox cboProcedencia;
        private System.Windows.Forms.ComboBox cbEpoca;
        private System.Windows.Forms.CheckBox chkEsCopia;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSeleccionarAutor;
        private System.Windows.Forms.Label lblErrorTitulo;
    }
}