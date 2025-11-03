namespace BackOfficeMuseo.Controls
{
    partial class CajaTexto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblErrorInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErrorInput
            // 
            this.lblErrorInput.AutoSize = true;
            this.lblErrorInput.ForeColor = System.Drawing.Color.Red;
            this.lblErrorInput.Location = new System.Drawing.Point(295, 20);
            this.lblErrorInput.Name = "lblErrorInput";
            this.lblErrorInput.Size = new System.Drawing.Size(11, 13);
            this.lblErrorInput.TabIndex = 15;
            this.lblErrorInput.Text = "*";
            this.lblErrorInput.Visible = false;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(54, 17);
            this.txtInput.MaxLength = 100;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(235, 20);
            this.txtInput.TabIndex = 14;
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblTitulo.TabIndex = 13;
            // 
            // CajaTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblErrorInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CajaTexto";
            this.Size = new System.Drawing.Size(320, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTitulo;
    }
}
