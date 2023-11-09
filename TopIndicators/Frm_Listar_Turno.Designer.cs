namespace TopIndicators
{
    partial class Frm_Listar_Turno
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
            this.btn_iniciada = new System.Windows.Forms.Button();
            this.btn_finalizada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_iniciada
            // 
            this.btn_iniciada.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_iniciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciada.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_iniciada.Location = new System.Drawing.Point(431, 125);
            this.btn_iniciada.Name = "btn_iniciada";
            this.btn_iniciada.Size = new System.Drawing.Size(318, 42);
            this.btn_iniciada.TabIndex = 7;
            this.btn_iniciada.Text = "ABERTO";
            this.btn_iniciada.UseVisualStyleBackColor = false;
            // 
            // btn_finalizada
            // 
            this.btn_finalizada.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_finalizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizada.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_finalizada.Location = new System.Drawing.Point(872, 125);
            this.btn_finalizada.Name = "btn_finalizada";
            this.btn_finalizada.Size = new System.Drawing.Size(318, 42);
            this.btn_finalizada.TabIndex = 6;
            this.btn_finalizada.Text = "FECHADO";
            this.btn_finalizada.UseVisualStyleBackColor = false;
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
            this.label1.Location = new System.Drawing.Point(729, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "TURNO";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(211, 224);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(215, 28);
            this.txtPesquisa.TabIndex = 141;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkGreen;
            this.label18.Location = new System.Drawing.Point(12, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 22);
            this.label18.TabIndex = 140;
            this.label18.Text = "NOME PRODUTO:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 560);
            this.panel1.TabIndex = 142;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(1171, 941);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 42);
            this.button1.TabIndex = 143;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_Listar_Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1550, 1018);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_iniciada);
            this.Controls.Add(this.btn_finalizada);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Listar_Turno";
            this.Text = "Frm_Listar_Turno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciada;
        private System.Windows.Forms.Button btn_finalizada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}