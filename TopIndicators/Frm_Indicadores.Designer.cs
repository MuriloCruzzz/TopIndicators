namespace TopIndicators
{
    partial class Frm_Indicadores
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
            this.btn_pendente = new System.Windows.Forms.Button();
            this.btn_finalizada = new System.Windows.Forms.Button();
            this.btn_iniciada = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(556, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUÇÃO";
            // 
            // btn_pendente
            // 
            this.btn_pendente.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_pendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pendente.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_pendente.Location = new System.Drawing.Point(88, 117);
            this.btn_pendente.Name = "btn_pendente";
            this.btn_pendente.Size = new System.Drawing.Size(318, 42);
            this.btn_pendente.TabIndex = 2;
            this.btn_pendente.Text = "PENDENTE";
            this.btn_pendente.UseVisualStyleBackColor = false;
            this.btn_pendente.Click += new System.EventHandler(this.btn_pendente_Click);
            // 
            // btn_finalizada
            // 
            this.btn_finalizada.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_finalizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizada.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_finalizada.Location = new System.Drawing.Point(974, 117);
            this.btn_finalizada.Name = "btn_finalizada";
            this.btn_finalizada.Size = new System.Drawing.Size(318, 42);
            this.btn_finalizada.TabIndex = 3;
            this.btn_finalizada.Text = "FINALIZADA";
            this.btn_finalizada.UseVisualStyleBackColor = false;
            this.btn_finalizada.Click += new System.EventHandler(this.btn_finalizada_Click);
            // 
            // btn_iniciada
            // 
            this.btn_iniciada.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_iniciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciada.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_iniciada.Location = new System.Drawing.Point(533, 117);
            this.btn_iniciada.Name = "btn_iniciada";
            this.btn_iniciada.Size = new System.Drawing.Size(318, 42);
            this.btn_iniciada.TabIndex = 4;
            this.btn_iniciada.Text = "INICIADA";
            this.btn_iniciada.UseVisualStyleBackColor = false;
            this.btn_iniciada.Click += new System.EventHandler(this.btn_iniciada_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 822);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 139.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(15, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1333, 264);
            this.label2.TabIndex = 0;
            this.label2.Text = "GRAFICOS";
            // 
            // Frm_Indicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1394, 1018);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_iniciada);
            this.Controls.Add(this.btn_finalizada);
            this.Controls.Add(this.btn_pendente);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Indicadores";
            this.Text = "Frm_Indicadores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pendente;
        private System.Windows.Forms.Button btn_finalizada;
        private System.Windows.Forms.Button btn_iniciada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}