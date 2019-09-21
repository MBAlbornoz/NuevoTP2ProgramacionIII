namespace Sistemas_Ventas_MSoft
{
    partial class FrmConfirmacion
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
            this.btnConfirmarSI = new System.Windows.Forms.Button();
            this.btnConfirmarNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfirmarSI
            // 
            this.btnConfirmarSI.Location = new System.Drawing.Point(12, 12);
            this.btnConfirmarSI.Name = "btnConfirmarSI";
            this.btnConfirmarSI.Size = new System.Drawing.Size(101, 24);
            this.btnConfirmarSI.TabIndex = 0;
            this.btnConfirmarSI.Text = "SI";
            this.btnConfirmarSI.UseVisualStyleBackColor = true;
        
            // 
            // btnConfirmarNO
            // 
            this.btnConfirmarNO.Location = new System.Drawing.Point(136, 12);
            this.btnConfirmarNO.Name = "btnConfirmarNO";
            this.btnConfirmarNO.Size = new System.Drawing.Size(101, 24);
            this.btnConfirmarNO.TabIndex = 1;
            this.btnConfirmarNO.Text = "NO";
            this.btnConfirmarNO.UseVisualStyleBackColor = true;
            // 
            // FrmConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 48);
            this.Controls.Add(this.btnConfirmarNO);
            this.Controls.Add(this.btnConfirmarSI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfirmacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Confirmar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarSI;
        private System.Windows.Forms.Button btnConfirmarNO;
    }
}