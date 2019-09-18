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
            this.altaArticuloTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaArticuloTlSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionArticuloTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaTSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.bajaArticuloTlSMenuItem,
            this.modificacionArticuloTSMenuItem,
            this.listarTSMenuItem,
            this.salirTSMenuItem});
            this.menuTSMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTSMenu.Name = "menuTSMenu";
            this.menuTSMenu.Size = new System.Drawing.Size(51, 20);
            this.menuTSMenu.Text = "Menu";
            // 
            // altaArticuloTSMenuItem
            // 
            this.altaArticuloTSMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.altaArticuloTSMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaArticuloTSMenuItem.Name = "altaArticuloTSMenuItem";
            this.altaArticuloTSMenuItem.Size = new System.Drawing.Size(187, 22);
            this.altaArticuloTSMenuItem.Text = "Alta Articulo";
            this.altaArticuloTSMenuItem.Click += new System.EventHandler(this.AltaArticuloTSMenuItem_Click);
            // 
            // bajaArticuloTlSMenuItem
            // 
            this.bajaArticuloTlSMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.bajaArticuloTlSMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaArticuloTlSMenuItem.Name = "bajaArticuloTlSMenuItem";
            this.bajaArticuloTlSMenuItem.Size = new System.Drawing.Size(187, 22);
            this.bajaArticuloTlSMenuItem.Text = "Baja Articulo";
            // 
            // modificacionArticuloTSMenuItem
            // 
            this.modificacionArticuloTSMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.modificacionArticuloTSMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionArticuloTSMenuItem.Name = "modificacionArticuloTSMenuItem";
            this.modificacionArticuloTSMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modificacionArticuloTSMenuItem.Text = "Modificar Articulo";
            // 
            // listarTSMenuItem
            // 
            this.listarTSMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarTSMenuItem.Name = "listarTSMenuItem";
            this.listarTSMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listarTSMenuItem.Text = "Listar Articulos";
            // 
            // salirTSMenuItem
            // 
            this.salirTSMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirTSMenuItem.Name = "salirTSMenuItem";
            this.salirTSMenuItem.Size = new System.Drawing.Size(187, 22);
            this.salirTSMenuItem.Text = "Salir";
            this.salirTSMenuItem.Click += new System.EventHandler(this.SalirTSMenuItem_Click_1);
            // 
            // busquedaTSMenu
            // 
            this.busquedaTSMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaTSMenu.Name = "busquedaTSMenu";
            this.busquedaTSMenu.Size = new System.Drawing.Size(73, 20);
            this.busquedaTSMenu.Text = "Busqueda";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
        private System.Windows.Forms.ToolStripMenuItem bajaArticuloTlSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaTSMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificacionArticuloTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirTSMenuItem;
    }
}

