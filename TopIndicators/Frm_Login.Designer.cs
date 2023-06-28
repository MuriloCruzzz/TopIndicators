namespace TopIndicators
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Pnl_Login = new System.Windows.Forms.Panel();
            this.Llbl_LinkSuporte = new System.Windows.Forms.LinkLabel();
            this.Btn_OlharSenha = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txb_SenhaLogin = new System.Windows.Forms.TextBox();
            this.Txb_NomeLogin = new System.Windows.Forms.TextBox();
            this.Lbl_Saudacoes = new System.Windows.Forms.Label();
            this.Pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Login
            // 
            this.Pnl_Login.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_Login.BackgroundImage")));
            this.Pnl_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_Login.Controls.Add(this.Llbl_LinkSuporte);
            this.Pnl_Login.Controls.Add(this.Btn_OlharSenha);
            this.Pnl_Login.Controls.Add(this.Btn_Login);
            this.Pnl_Login.Controls.Add(this.Txb_SenhaLogin);
            this.Pnl_Login.Controls.Add(this.Txb_NomeLogin);
            this.Pnl_Login.Controls.Add(this.Lbl_Saudacoes);
            this.Pnl_Login.Location = new System.Drawing.Point(0, -1);
            this.Pnl_Login.Name = "Pnl_Login";
            this.Pnl_Login.Size = new System.Drawing.Size(345, 540);
            this.Pnl_Login.TabIndex = 0;
            this.Pnl_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Llbl_LinkSuporte
            // 
            this.Llbl_LinkSuporte.AutoSize = true;
            this.Llbl_LinkSuporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llbl_LinkSuporte.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.Llbl_LinkSuporte.Location = new System.Drawing.Point(135, 521);
            this.Llbl_LinkSuporte.Name = "Llbl_LinkSuporte";
            this.Llbl_LinkSuporte.Size = new System.Drawing.Size(82, 18);
            this.Llbl_LinkSuporte.TabIndex = 5;
            this.Llbl_LinkSuporte.TabStop = true;
            this.Llbl_LinkSuporte.Text = "Suporte >";
            this.Llbl_LinkSuporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Llbl_LinkSuporte.UseMnemonic = false;
            this.Llbl_LinkSuporte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbl_LinkSuporte_LinkClicked);
            // 
            // Btn_OlharSenha
            // 
            this.Btn_OlharSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_OlharSenha.BackgroundImage")));
            this.Btn_OlharSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_OlharSenha.FlatAppearance.BorderSize = 0;
            this.Btn_OlharSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OlharSenha.Location = new System.Drawing.Point(248, 334);
            this.Btn_OlharSenha.Name = "Btn_OlharSenha";
            this.Btn_OlharSenha.Size = new System.Drawing.Size(20, 20);
            this.Btn_OlharSenha.TabIndex = 4;
            this.Btn_OlharSenha.UseVisualStyleBackColor = true;
            this.Btn_OlharSenha.Click += new System.EventHandler(this.Btn_OlharSenha_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Teal;
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Login.Location = new System.Drawing.Point(126, 380);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 34);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "ENTRAR";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Txb_SenhaLogin
            // 
            this.Txb_SenhaLogin.BackColor = System.Drawing.Color.Honeydew;
            this.Txb_SenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_SenhaLogin.Location = new System.Drawing.Point(105, 339);
            this.Txb_SenhaLogin.Name = "Txb_SenhaLogin";
            this.Txb_SenhaLogin.PasswordChar = '*';
            this.Txb_SenhaLogin.Size = new System.Drawing.Size(131, 15);
            this.Txb_SenhaLogin.TabIndex = 2;
            // 
            // Txb_NomeLogin
            // 
            this.Txb_NomeLogin.BackColor = System.Drawing.Color.Honeydew;
            this.Txb_NomeLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_NomeLogin.Location = new System.Drawing.Point(105, 296);
            this.Txb_NomeLogin.Name = "Txb_NomeLogin";
            this.Txb_NomeLogin.Size = new System.Drawing.Size(131, 15);
            this.Txb_NomeLogin.TabIndex = 1;
            // 
            // Lbl_Saudacoes
            // 
            this.Lbl_Saudacoes.AutoSize = true;
            this.Lbl_Saudacoes.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Saudacoes.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saudacoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Saudacoes.Location = new System.Drawing.Point(112, 99);
            this.Lbl_Saudacoes.Name = "Lbl_Saudacoes";
            this.Lbl_Saudacoes.Size = new System.Drawing.Size(114, 25);
            this.Lbl_Saudacoes.TabIndex = 0;
            this.Lbl_Saudacoes.Text = "Saudações";
            this.Lbl_Saudacoes.AutoSizeChanged += new System.EventHandler(this.Lbl_Saudacoes_AutoSizeChanged);
            this.Lbl_Saudacoes.Click += new System.EventHandler(this.Lbl_Saudacoes_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 539);
            this.Controls.Add(this.Pnl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Pnl_Login.ResumeLayout(false);
            this.Pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Login;
        private System.Windows.Forms.Label Lbl_Saudacoes;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txb_SenhaLogin;
        private System.Windows.Forms.TextBox Txb_NomeLogin;
        private System.Windows.Forms.Button Btn_OlharSenha;
        private System.Windows.Forms.LinkLabel Llbl_LinkSuporte;
    }
}

