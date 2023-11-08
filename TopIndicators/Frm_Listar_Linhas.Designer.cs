namespace TopIndicators
{
    partial class Frm_Listar_Linhas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Consultar_Linhas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(399, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 69);
            this.label1.TabIndex = 25;
            this.label1.Text = "CONSULTAR LINHAS";
            // 
            // Pnl_Consultar_Linhas
            // 
            this.Pnl_Consultar_Linhas.Location = new System.Drawing.Point(12, 160);
            this.Pnl_Consultar_Linhas.Name = "Pnl_Consultar_Linhas";
            this.Pnl_Consultar_Linhas.Size = new System.Drawing.Size(1442, 775);
            this.Pnl_Consultar_Linhas.TabIndex = 26;
            // 
            // Frm_Listar_Linhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1459, 961);
            this.Controls.Add(this.Pnl_Consultar_Linhas);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Listar_Linhas";
            this.Text = "Frm_Listar_Linhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_Consultar_Linhas;
    }
}