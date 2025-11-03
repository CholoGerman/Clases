namespace BackOfficeMuseo.Autores
{
    partial class FrmAutor
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
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.grbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Location = new System.Drawing.Point(22, 28);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAutor.TabIndex = 0;
            this.lblNombreAutor.Text = "Nombre:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(93, 25);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(181, 20);
            this.txtAutor.TabIndex = 1;
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(12, 103);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(776, 262);
            this.dgvAutores.TabIndex = 2;
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.btnBuscar);
            this.grbBusqueda.Controls.Add(this.lblNombreAutor);
            this.grbBusqueda.Controls.Add(this.txtAutor);
            this.grbBusqueda.Location = new System.Drawing.Point(33, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(736, 85);
            this.grbBusqueda.TabIndex = 3;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(303, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(572, 391);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(688, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.dgvAutores);
            this.Name = "FrmAutor";
            this.Text = "Catalogo de autores";
            this.Load += new System.EventHandler(this.FrmAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
    }
}