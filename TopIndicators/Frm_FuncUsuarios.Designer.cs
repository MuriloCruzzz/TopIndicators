namespace TopIndicators
{
    partial class Frm_FuncUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FuncUsuarios));
            this.Btn_NovoUsuario = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.panel_c_1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_c_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_NovoUsuario
            // 
            this.Btn_NovoUsuario.BackColor = System.Drawing.Color.LightGray;
            this.Btn_NovoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.Btn_NovoUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_NovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NovoUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_NovoUsuario.Location = new System.Drawing.Point(45, 8);
            this.Btn_NovoUsuario.Name = "Btn_NovoUsuario";
            this.Btn_NovoUsuario.Size = new System.Drawing.Size(270, 52);
            this.Btn_NovoUsuario.TabIndex = 0;
            this.Btn_NovoUsuario.Text = "NOVO USUARIO";
            this.Btn_NovoUsuario.UseVisualStyleBackColor = false;
            this.Btn_NovoUsuario.Click += new System.EventHandler(this.Btn_NovoUsuario_Click);
            this.Btn_NovoUsuario.MouseEnter += new System.EventHandler(this.Btn_NovoUsuario_MouseEnter);
            this.Btn_NovoUsuario.MouseLeave += new System.EventHandler(this.Btn_NovoUsuario_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(19, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "LISTAR USUARIOS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel_2
            // 
            this.panel_2.Location = new System.Drawing.Point(12, 12);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(1546, 914);
            this.panel_2.TabIndex = 4;
            // 
            // panel_c_1
            // 
            this.panel_c_1.Controls.Add(this.Btn_NovoUsuario);
            this.panel_c_1.Location = new System.Drawing.Point(12, 924);
            this.panel_c_1.Name = "panel_c_1";
            this.panel_c_1.Size = new System.Drawing.Size(375, 68);
            this.panel_c_1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(403, 924);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 68);
            this.panel1.TabIndex = 6;
            // 
            // Frm_FuncUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1582, 996);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_c_1);
            this.Controls.Add(this.panel_2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FuncUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos Cadastro Usuario";
            this.Load += new System.EventHandler(this.Frm_FuncUsuarios_Load);
            this.panel_c_1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_NovoUsuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel_c_1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel_2;
    }
}