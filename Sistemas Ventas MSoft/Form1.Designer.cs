namespace Sistemas_Ventas_MSoft
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaTSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.altaArticuloTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloTlSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarArticulosTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BajaArticuloTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTSMenu,
            this.busquedaTSMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTSMenu
            // 
            this.menuTSMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaArticuloTSMenuItem,
            this.modificarArticuloTlSMenuItem,
            this.BajaArticuloTSMenuItem,
            this.salirTSMenuItem});
            this.menuTSMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTSMenu.Name = "menuTSMenu";
            this.menuTSMenu.Size = new System.Drawing.Size(51, 20);
            this.menuTSMenu.Text = "Menu";
            // 
            // busquedaTSMenu
            // 
            this.busquedaTSMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarArticulosTSMenuItem,
            this.busquedaTSMenuItem});
            this.busquedaTSMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaTSMenu.Name = "busquedaTSMenu";
            this.busquedaTSMenu.Size = new System.Drawing.Size(73, 20);
            this.busquedaTSMenu.Text = "Busqueda";
            // 
            // altaArticuloTSMenuItem
            // 
            this.altaArticuloTSMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.altaArticuloTSMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaArticuloTSMenuItem.Name = "altaArticuloTSMenuItem";
            this.altaArticuloTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaArticuloTSMenuItem.Text = "Alta Articulo";
            this.altaArticuloTSMenuItem.Click += new System.EventHandler(this.AltaArticuloTSMenuItem_Click);
            // 
            // modificarArticuloTlSMenuItem
            // 
            this.modificarArticuloTlSMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.modificarArticuloTlSMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarArticuloTlSMenuItem.Name = "modificarArticuloTlSMenuItem";
            this.modificarArticuloTlSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarArticuloTlSMenuItem.Text = "Modificar Articulo";
            // 
            // listarArticulosTSMenuItem
            // 
            this.listarArticulosTSMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.listarArticulosTSMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarArticulosTSMenuItem.Name = "listarArticulosTSMenuItem";
            this.listarArticulosTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarArticulosTSMenuItem.Text = "Listar Articulos";
            // 
            // busquedaTSMenuItem
            // 
            this.busquedaTSMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.busquedaTSMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaTSMenuItem.Name = "busquedaTSMenuItem";
            this.busquedaTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.busquedaTSMenuItem.Text = "Busqueda";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BajaArticuloTSMenuItem
            // 
            this.BajaArticuloTSMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.BajaArticuloTSMenuItem.Name = "BajaArticuloTSMenuItem";
            this.BajaArticuloTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BajaArticuloTSMenuItem.Text = "Baja Articulo";
            // 
            // salirTSMenuItem
            // 
            this.salirTSMenuItem.Name = "salirTSMenuItem";
            this.salirTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirTSMenuItem.Text = "Salir";
            this.salirTSMenuItem.Click += new System.EventHandler(this.SalirTSMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema Ventas MSoft";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTSMenu;
        private System.Windows.Forms.ToolStripMenuItem altaArticuloTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloTlSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaTSMenu;
        private System.Windows.Forms.ToolStripMenuItem listarArticulosTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaTSMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BajaArticuloTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirTSMenuItem;
    }
}

