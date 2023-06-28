namespace TopIndicators
{
    partial class Frm_CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroUsuario));
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.Lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.Lbl_CadastroSenha = new System.Windows.Forms.Label();
            this.Lbl_CadastroSenhaValidação = new System.Windows.Forms.Label();
            this.Btn_CadastrarNovoUsuario = new System.Windows.Forms.Button();
            this.Txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.Txt_ConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.Lbl_NomeSetor = new System.Windows.Forms.Label();
            this.Txt_NomeSetor = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_NivelSenha = new System.Windows.Forms.Label();
            this.Btn_OlharSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Cadastro
            // 
            this.Lbl_Cadastro.AutoSize = true;
            this.Lbl_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cadastro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Cadastro.Location = new System.Drawing.Point(27, 59);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(405, 46);
            this.Lbl_Cadastro.TabIndex = 0;
            this.Lbl_Cadastro.Text = "Cadastro de Usuário";
            // 
            // Lbl_NomeUsuario
            // 
            this.Lbl_NomeUsuario.AutoSize = true;
            this.Lbl_NomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NomeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_NomeUsuario.Location = new System.Drawing.Point(27, 205);
            this.Lbl_NomeUsuario.Name = "Lbl_NomeUsuario";
            this.Lbl_NomeUsuario.Size = new System.Drawing.Size(132, 42);
            this.Lbl_NomeUsuario.TabIndex = 1;
            this.Lbl_NomeUsuario.Text = "Nome:";
            // 
            // Lbl_CadastroSenha
            // 
            this.Lbl_CadastroSenha.AutoSize = true;
            this.Lbl_CadastroSenha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CadastroSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_CadastroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CadastroSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_CadastroSenha.Location = new System.Drawing.Point(23, 285);
            this.Lbl_CadastroSenha.Name = "Lbl_CadastroSenha";
            this.Lbl_CadastroSenha.Size = new System.Drawing.Size(143, 42);
            this.Lbl_CadastroSenha.TabIndex = 2;
            this.Lbl_CadastroSenha.Text = "Senha:";
            // 
            // Lbl_CadastroSenhaValidação
            // 
            this.Lbl_CadastroSenhaValidação.AutoSize = true;
            this.Lbl_CadastroSenhaValidação.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CadastroSenhaValidação.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_CadastroSenhaValidação.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CadastroSenhaValidação.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_CadastroSenhaValidação.Location = new System.Drawing.Point(27, 363);
            this.Lbl_CadastroSenhaValidação.Name = "Lbl_CadastroSenhaValidação";
            this.Lbl_CadastroSenhaValidação.Size = new System.Drawing.Size(312, 42);
            this.Lbl_CadastroSenhaValidação.TabIndex = 3;
            this.Lbl_CadastroSenhaValidação.Text = "Confirma Senha:";
            // 
            // Btn_CadastrarNovoUsuario
            // 
            this.Btn_CadastrarNovoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_CadastrarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CadastrarNovoUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_CadastrarNovoUsuario.Location = new System.Drawing.Point(495, 491);
            this.Btn_CadastrarNovoUsuario.Name = "Btn_CadastrarNovoUsuario";
            this.Btn_CadastrarNovoUsuario.Size = new System.Drawing.Size(150, 48);
            this.Btn_CadastrarNovoUsuario.TabIndex = 4;
            this.Btn_CadastrarNovoUsuario.Text = "CADASTRAR";
            this.Btn_CadastrarNovoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_CadastrarNovoUsuario.UseVisualStyleBackColor = false;
            this.Btn_CadastrarNovoUsuario.Click += new System.EventHandler(this.Btn_CadastrarNovoUsuario_Click);
            // 
            // Txt_NomeUsuario
            // 
            this.Txt_NomeUsuario.Location = new System.Drawing.Point(159, 218);
            this.Txt_NomeUsuario.Name = "Txt_NomeUsuario";
            this.Txt_NomeUsuario.Size = new System.Drawing.Size(448, 22);
            this.Txt_NomeUsuario.TabIndex = 6;
            // 
            // Txt_ConfirmacaoSenha
            // 
            this.Txt_ConfirmacaoSenha.Location = new System.Drawing.Point(354, 376);
            this.Txt_ConfirmacaoSenha.Name = "Txt_ConfirmacaoSenha";
            this.Txt_ConfirmacaoSenha.PasswordChar = '*';
            this.Txt_ConfirmacaoSenha.Size = new System.Drawing.Size(241, 22);
            this.Txt_ConfirmacaoSenha.TabIndex = 7;
            // 
            // Lbl_NomeSetor
            // 
            this.Lbl_NomeSetor.AutoSize = true;
            this.Lbl_NomeSetor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NomeSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_NomeSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeSetor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_NomeSetor.Location = new System.Drawing.Point(27, 449);
            this.Lbl_NomeSetor.Name = "Lbl_NomeSetor";
            this.Lbl_NomeSetor.Size = new System.Drawing.Size(123, 42);
            this.Lbl_NomeSetor.TabIndex = 8;
            this.Lbl_NomeSetor.Text = "Setor:";
            // 
            // Txt_NomeSetor
            // 
            this.Txt_NomeSetor.Location = new System.Drawing.Point(151, 463);
            this.Txt_NomeSetor.Name = "Txt_NomeSetor";
            this.Txt_NomeSetor.Size = new System.Drawing.Size(241, 22);
            this.Txt_NomeSetor.TabIndex = 9;
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Resultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Resultado.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Resultado.Location = new System.Drawing.Point(490, 314);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Resultado.TabIndex = 10;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(165, 299);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(230, 22);
            this.Txt_Senha.TabIndex = 11;
            this.Txt_Senha.TextChanged += new System.EventHandler(this.Txt_Senha_TextChanged);
            // 
            // Lbl_NivelSenha
            // 
            this.Lbl_NivelSenha.AutoSize = true;
            this.Lbl_NivelSenha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NivelSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_NivelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NivelSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_NivelSenha.Location = new System.Drawing.Point(446, 269);
            this.Lbl_NivelSenha.Name = "Lbl_NivelSenha";
            this.Lbl_NivelSenha.Size = new System.Drawing.Size(159, 25);
            this.Lbl_NivelSenha.TabIndex = 12;
            this.Lbl_NivelSenha.Text = "Nivel da Senha";
            // 
            // Btn_OlharSenha
            // 
            this.Btn_OlharSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_OlharSenha.BackgroundImage")));
            this.Btn_OlharSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_OlharSenha.FlatAppearance.BorderSize = 0;
            this.Btn_OlharSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OlharSenha.Location = new System.Drawing.Point(401, 299);
            this.Btn_OlharSenha.Name = "Btn_OlharSenha";
            this.Btn_OlharSenha.Size = new System.Drawing.Size(20, 20);
            this.Btn_OlharSenha.TabIndex = 13;
            this.Btn_OlharSenha.UseVisualStyleBackColor = true;
            this.Btn_OlharSenha.Click += new System.EventHandler(this.Btn_OlharSenha_Click);
            // 
            // Frm_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 579);
            this.Controls.Add(this.Btn_OlharSenha);
            this.Controls.Add(this.Lbl_NivelSenha);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Txt_NomeSetor);
            this.Controls.Add(this.Lbl_NomeSetor);
            this.Controls.Add(this.Txt_ConfirmacaoSenha);
            this.Controls.Add(this.Txt_NomeUsuario);
            this.Controls.Add(this.Btn_CadastrarNovoUsuario);
            this.Controls.Add(this.Lbl_CadastroSenhaValidação);
            this.Controls.Add(this.Lbl_CadastroSenha);
            this.Controls.Add(this.Lbl_NomeUsuario);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Cadastro;
        private System.Windows.Forms.Label Lbl_NomeUsuario;
        private System.Windows.Forms.Label Lbl_CadastroSenha;
        private System.Windows.Forms.Label Lbl_CadastroSenhaValidação;
        private System.Windows.Forms.Button Btn_CadastrarNovoUsuario;
        private System.Windows.Forms.TextBox Txt_NomeUsuario;
        private System.Windows.Forms.TextBox Txt_ConfirmacaoSenha;
        private System.Windows.Forms.Label Lbl_NomeSetor;
        private System.Windows.Forms.TextBox Txt_NomeSetor;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_NivelSenha;
        private System.Windows.Forms.Button Btn_OlharSenha;
    }
}