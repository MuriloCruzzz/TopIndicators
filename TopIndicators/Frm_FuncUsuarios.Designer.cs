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
            this.Btn_alterarUsuario = new System.Windows.Forms.Button();
            this.Btn_ExcluirUsuario = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_NovoUsuario
            // 
            this.Btn_NovoUsuario.Location = new System.Drawing.Point(68, 66);
            this.Btn_NovoUsuario.Name = "Btn_NovoUsuario";
            this.Btn_NovoUsuario.Size = new System.Drawing.Size(270, 126);
            this.Btn_NovoUsuario.TabIndex = 0;
            this.Btn_NovoUsuario.Text = "NOVO USUARIO";
            this.Btn_NovoUsuario.UseVisualStyleBackColor = true;
            this.Btn_NovoUsuario.Click += new System.EventHandler(this.Btn_NovoUsuario_Click);
            // 
            // Btn_alterarUsuario
            // 
            this.Btn_alterarUsuario.Location = new System.Drawing.Point(68, 275);
            this.Btn_alterarUsuario.Name = "Btn_alterarUsuario";
            this.Btn_alterarUsuario.Size = new System.Drawing.Size(270, 126);
            this.Btn_alterarUsuario.TabIndex = 1;
            this.Btn_alterarUsuario.Text = "ALTERAR USUARIO";
            this.Btn_alterarUsuario.UseVisualStyleBackColor = true;
            // 
            // Btn_ExcluirUsuario
            // 
            this.Btn_ExcluirUsuario.Location = new System.Drawing.Point(442, 66);
            this.Btn_ExcluirUsuario.Name = "Btn_ExcluirUsuario";
            this.Btn_ExcluirUsuario.Size = new System.Drawing.Size(270, 126);
            this.Btn_ExcluirUsuario.TabIndex = 2;
            this.Btn_ExcluirUsuario.Text = "EXCLUIR USUARIO";
            this.Btn_ExcluirUsuario.UseVisualStyleBackColor = true;
            this.Btn_ExcluirUsuario.Click += new System.EventHandler(this.Btn_ExcluirUsuario_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 126);
            this.button4.TabIndex = 3;
            this.button4.Text = "LISTAR USUARIOS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_FuncUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_ExcluirUsuario);
            this.Controls.Add(this.Btn_alterarUsuario);
            this.Controls.Add(this.Btn_NovoUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_FuncUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos Cadastro Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_NovoUsuario;
        private System.Windows.Forms.Button Btn_alterarUsuario;
        private System.Windows.Forms.Button Btn_ExcluirUsuario;
        private System.Windows.Forms.Button button4;
    }
}