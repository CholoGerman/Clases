namespace BackOfficeMuseo
{
    partial class Main
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrasToolStripMenuItem,
            this.procedenciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obrasToolStripMenuItem
            // 
            this.obrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            this.obrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.obrasToolStripMenuItem.Text = "Obras";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // procedenciasToolStripMenuItem
            // 
            this.procedenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoToolStripMenuItem,
            this.donacionToolStripMenuItem,
            this.compraToolStripMenuItem});
            this.procedenciasToolStripMenuItem.Name = "procedenciasToolStripMenuItem";
            this.procedenciasToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.procedenciasToolStripMenuItem.Text = "Procedencias";
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prestamoToolStripMenuItem.Text = "Prestamo";
            this.prestamoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // donacionToolStripMenuItem
            // 
            this.donacionToolStripMenuItem.Name = "donacionToolStripMenuItem";
            this.donacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donacionToolStripMenuItem.Text = "Donacion";
            this.donacionToolStripMenuItem.Click += new System.EventHandler(this.donacionToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 483);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de Museo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
    }
}

