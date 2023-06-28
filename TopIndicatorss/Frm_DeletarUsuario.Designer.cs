namespace TopIndicators
{
    partial class Frm_DeletarUsuario
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
            this.Btn_DeletarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_idUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_DeletarUsuario
            // 
            this.Btn_DeletarUsuario.Location = new System.Drawing.Point(313, 52);
            this.Btn_DeletarUsuario.Name = "Btn_DeletarUsuario";
            this.Btn_DeletarUsuario.Size = new System.Drawing.Size(147, 65);
            this.Btn_DeletarUsuario.TabIndex = 0;
            this.Btn_DeletarUsuario.TabStop = false;
            this.Btn_DeletarUsuario.Text = "DELETAR";
            this.Btn_DeletarUsuario.UseVisualStyleBackColor = true;
            this.Btn_DeletarUsuario.Click += new System.EventHandler(this.Btn_DeletarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUAL ID DE USUARIO DESEJA DELETAR?";
            // 
            // Txt_idUsuario
            // 
            this.Txt_idUsuario.Location = new System.Drawing.Point(86, 73);
            this.Txt_idUsuario.Name = "Txt_idUsuario";
            this.Txt_idUsuario.Size = new System.Drawing.Size(133, 22);
            this.Txt_idUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // Frm_DeletarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 136);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_idUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_DeletarUsuario);
            this.Name = "Frm_DeletarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Deletar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_DeletarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_idUsuario;
        private System.Windows.Forms.Label label2;
    }
}