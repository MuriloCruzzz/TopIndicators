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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroUsuario));
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.Lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.Lbl_CadastroSenha = new System.Windows.Forms.Label();
            this.Lbl_CadastroSenhaValidação = new System.Windows.Forms.Label();
            this.Btn_CadastrarNovoUsuario = new System.Windows.Forms.Button();
            this.Txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.Txt_ConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.Lbl_NomeSetor = new System.Windows.Forms.Label();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_NivelSenha = new System.Windows.Forms.Label();
            this.Btn_OlharSenha = new System.Windows.Forms.Button();
            this.Txt_NomeSetor2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_estado = new System.Windows.Forms.ComboBox();
            this.txb_cep = new System.Windows.Forms.TextBox();
            this.tcbtelefone = new System.Windows.Forms.TextBox();
            this.txb_cpf = new System.Windows.Forms.TextBox();
            this.lbl_dataNasc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_endereco = new System.Windows.Forms.TextBox();
            this.txb_bairro = new System.Windows.Forms.TextBox();
            this.txb_cidade = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Cadastro
            // 
            this.Lbl_Cadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cadastro.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_Cadastro.Location = new System.Drawing.Point(149, 35);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(1114, 99);
            this.Lbl_Cadastro.TabIndex = 0;
            this.Lbl_Cadastro.Text = "Cadastro de Usuário";
            this.Lbl_Cadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_NomeUsuario
            // 
            this.Lbl_NomeUsuario.AutoSize = true;
            this.Lbl_NomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NomeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeUsuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_NomeUsuario.Location = new System.Drawing.Point(27, 163);
            this.Lbl_NomeUsuario.Name = "Lbl_NomeUsuario";
            this.Lbl_NomeUsuario.Size = new System.Drawing.Size(108, 38);
            this.Lbl_NomeUsuario.TabIndex = 1;
            this.Lbl_NomeUsuario.Text = "Nome";
            // 
            // Lbl_CadastroSenha
            // 
            this.Lbl_CadastroSenha.AutoSize = true;
            this.Lbl_CadastroSenha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CadastroSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_CadastroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CadastroSenha.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_CadastroSenha.Location = new System.Drawing.Point(31, 275);
            this.Lbl_CadastroSenha.Name = "Lbl_CadastroSenha";
            this.Lbl_CadastroSenha.Size = new System.Drawing.Size(106, 36);
            this.Lbl_CadastroSenha.TabIndex = 2;
            this.Lbl_CadastroSenha.Text = "Senha";
            // 
            // Lbl_CadastroSenhaValidação
            // 
            this.Lbl_CadastroSenhaValidação.AutoSize = true;
            this.Lbl_CadastroSenhaValidação.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CadastroSenhaValidação.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_CadastroSenhaValidação.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CadastroSenhaValidação.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_CadastroSenhaValidação.Location = new System.Drawing.Point(438, 277);
            this.Lbl_CadastroSenhaValidação.Name = "Lbl_CadastroSenhaValidação";
            this.Lbl_CadastroSenhaValidação.Size = new System.Drawing.Size(242, 36);
            this.Lbl_CadastroSenhaValidação.TabIndex = 3;
            this.Lbl_CadastroSenhaValidação.Text = "Confirma Senha";
            // 
            // Btn_CadastrarNovoUsuario
            // 
            this.Btn_CadastrarNovoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CadastrarNovoUsuario.BackColor = System.Drawing.Color.DarkGreen;
            this.Btn_CadastrarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CadastrarNovoUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_CadastrarNovoUsuario.Location = new System.Drawing.Point(1095, 884);
            this.Btn_CadastrarNovoUsuario.Name = "Btn_CadastrarNovoUsuario";
            this.Btn_CadastrarNovoUsuario.Size = new System.Drawing.Size(218, 86);
            this.Btn_CadastrarNovoUsuario.TabIndex = 4;
            this.Btn_CadastrarNovoUsuario.Text = "CADASTRAR";
            this.Btn_CadastrarNovoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_CadastrarNovoUsuario.UseVisualStyleBackColor = false;
            this.Btn_CadastrarNovoUsuario.Click += new System.EventHandler(this.Btn_CadastrarNovoUsuario_Click);
            // 
            // Txt_NomeUsuario
            // 
            this.Txt_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeUsuario.Location = new System.Drawing.Point(148, 165);
            this.Txt_NomeUsuario.Name = "Txt_NomeUsuario";
            this.Txt_NomeUsuario.Size = new System.Drawing.Size(448, 41);
            this.Txt_NomeUsuario.TabIndex = 6;
            this.Txt_NomeUsuario.TextChanged += new System.EventHandler(this.Txt_NomeUsuario_TextChanged);
            // 
            // Txt_ConfirmacaoSenha
            // 
            this.Txt_ConfirmacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConfirmacaoSenha.Location = new System.Drawing.Point(709, 275);
            this.Txt_ConfirmacaoSenha.Name = "Txt_ConfirmacaoSenha";
            this.Txt_ConfirmacaoSenha.PasswordChar = '*';
            this.Txt_ConfirmacaoSenha.Size = new System.Drawing.Size(326, 41);
            this.Txt_ConfirmacaoSenha.TabIndex = 7;
            // 
            // Lbl_NomeSetor
            // 
            this.Lbl_NomeSetor.AutoSize = true;
            this.Lbl_NomeSetor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NomeSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_NomeSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Lbl_NomeSetor.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_NomeSetor.Location = new System.Drawing.Point(39, 369);
            this.Lbl_NomeSetor.Name = "Lbl_NomeSetor";
            this.Lbl_NomeSetor.Size = new System.Drawing.Size(91, 36);
            this.Lbl_NomeSetor.TabIndex = 8;
            this.Lbl_NomeSetor.Text = "Setor";
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.BackColor = System.Drawing.Color.Honeydew;
            this.Lbl_Resultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Resultado.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Resultado.Location = new System.Drawing.Point(1210, 283);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Resultado.TabIndex = 10;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Senha.Location = new System.Drawing.Point(143, 275);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(280, 41);
            this.Txt_Senha.TabIndex = 11;
            this.Txt_Senha.TextChanged += new System.EventHandler(this.Txt_Senha_TextChanged);
            // 
            // Lbl_NivelSenha
            // 
            this.Lbl_NivelSenha.AutoSize = true;
            this.Lbl_NivelSenha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NivelSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_NivelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NivelSenha.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_NivelSenha.Location = new System.Drawing.Point(1141, 243);
            this.Lbl_NivelSenha.Name = "Lbl_NivelSenha";
            this.Lbl_NivelSenha.Size = new System.Drawing.Size(190, 29);
            this.Lbl_NivelSenha.TabIndex = 12;
            this.Lbl_NivelSenha.Text = "Nivel da Senha";
            // 
            // Btn_OlharSenha
            // 
            this.Btn_OlharSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_OlharSenha.BackgroundImage")));
            this.Btn_OlharSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_OlharSenha.FlatAppearance.BorderSize = 0;
            this.Btn_OlharSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OlharSenha.Location = new System.Drawing.Point(1041, 279);
            this.Btn_OlharSenha.Name = "Btn_OlharSenha";
            this.Btn_OlharSenha.Size = new System.Drawing.Size(40, 37);
            this.Btn_OlharSenha.TabIndex = 13;
            this.Btn_OlharSenha.UseVisualStyleBackColor = true;
            this.Btn_OlharSenha.Click += new System.EventHandler(this.Btn_OlharSenha_Click);
            // 
            // Txt_NomeSetor2
            // 
            this.Txt_NomeSetor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeSetor2.FormattingEnabled = true;
            this.Txt_NomeSetor2.Items.AddRange(new object[] {
            "ALMOXARIFADO",
            "AVO",
            "LOGISTICA"});
            this.Txt_NomeSetor2.Location = new System.Drawing.Point(135, 371);
            this.Txt_NomeSetor2.Name = "Txt_NomeSetor2";
            this.Txt_NomeSetor2.Size = new System.Drawing.Size(272, 44);
            this.Txt_NomeSetor2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(916, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 41);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(761, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario";
            // 
            // txb_estado
            // 
            this.txb_estado.Enabled = false;
            this.txb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_estado.FormattingEnabled = true;
            this.txb_estado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.txb_estado.Location = new System.Drawing.Point(160, 701);
            this.txb_estado.Name = "txb_estado";
            this.txb_estado.Size = new System.Drawing.Size(215, 30);
            this.txb_estado.TabIndex = 184;
            this.txb_estado.SelectedIndexChanged += new System.EventHandler(this.txb_estado_SelectedIndexChanged);
            // 
            // txb_cep
            // 
            this.txb_cep.Enabled = false;
            this.txb_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cep.Location = new System.Drawing.Point(1049, 699);
            this.txb_cep.Name = "txb_cep";
            this.txb_cep.Size = new System.Drawing.Size(264, 38);
            this.txb_cep.TabIndex = 173;
            // 
            // tcbtelefone
            // 
            this.tcbtelefone.Enabled = false;
            this.tcbtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcbtelefone.Location = new System.Drawing.Point(1081, 371);
            this.tcbtelefone.Name = "tcbtelefone";
            this.tcbtelefone.Size = new System.Drawing.Size(276, 38);
            this.tcbtelefone.TabIndex = 168;
            // 
            // txb_cpf
            // 
            this.txb_cpf.Enabled = false;
            this.txb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cpf.Location = new System.Drawing.Point(543, 374);
            this.txb_cpf.Name = "txb_cpf";
            this.txb_cpf.Size = new System.Drawing.Size(333, 38);
            this.txb_cpf.TabIndex = 167;
            // 
            // lbl_dataNasc
            // 
            this.lbl_dataNasc.AutoSize = true;
            this.lbl_dataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_dataNasc.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_dataNasc.Location = new System.Drawing.Point(630, 463);
            this.lbl_dataNasc.Name = "lbl_dataNasc";
            this.lbl_dataNasc.Size = new System.Drawing.Size(255, 36);
            this.lbl_dataNasc.TabIndex = 183;
            this.lbl_dataNasc.Text = "Data Nascimento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(39, 695);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 36);
            this.label9.TabIndex = 181;
            this.label9.Text = "Estado";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(477, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 36);
            this.label8.TabIndex = 180;
            this.label8.Text = "Cidade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(37, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 36);
            this.label7.TabIndex = 179;
            this.label7.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(686, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 36);
            this.label6.TabIndex = 178;
            this.label6.Text = "Bairro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(966, 699);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 36);
            this.label5.TabIndex = 177;
            this.label5.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(931, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 36);
            this.label3.TabIndex = 175;
            this.label3.Text = "Telefone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(460, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 36);
            this.label14.TabIndex = 174;
            this.label14.Text = "CPF";
            // 
            // txb_endereco
            // 
            this.txb_endereco.Enabled = false;
            this.txb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_endereco.Location = new System.Drawing.Point(210, 555);
            this.txb_endereco.Name = "txb_endereco";
            this.txb_endereco.Size = new System.Drawing.Size(284, 38);
            this.txb_endereco.TabIndex = 171;
            this.txb_endereco.TextChanged += new System.EventHandler(this.txb_endereco_TextChanged);
            // 
            // txb_bairro
            // 
            this.txb_bairro.Enabled = false;
            this.txb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_bairro.Location = new System.Drawing.Point(799, 558);
            this.txb_bairro.Name = "txb_bairro";
            this.txb_bairro.Size = new System.Drawing.Size(288, 38);
            this.txb_bairro.TabIndex = 172;
            this.txb_bairro.TextChanged += new System.EventHandler(this.txb_bairro_TextChanged);
            // 
            // txb_cidade
            // 
            this.txb_cidade.Enabled = false;
            this.txb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cidade.Location = new System.Drawing.Point(622, 698);
            this.txb_cidade.Name = "txb_cidade";
            this.txb_cidade.Size = new System.Drawing.Size(274, 38);
            this.txb_cidade.TabIndex = 170;
            this.txb_cidade.TextChanged += new System.EventHandler(this.txb_cidade_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(139, 463);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 38);
            this.textBox2.TabIndex = 185;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(38, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 186;
            this.label2.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(911, 466);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 38);
            this.textBox3.TabIndex = 187;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Supervidor",
            "Operador",
            "Lider"});
            this.comboBox1.Location = new System.Drawing.Point(148, 816);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 30);
            this.comboBox1.TabIndex = 189;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(39, 808);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 36);
            this.label4.TabIndex = 188;
            this.label4.Text = "Cargo";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(DadosUsuarios.Usuario);
            // 
            // Frm_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 1018);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_estado);
            this.Controls.Add(this.txb_cep);
            this.Controls.Add(this.tcbtelefone);
            this.Controls.Add(this.txb_cpf);
            this.Controls.Add(this.lbl_dataNasc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txb_endereco);
            this.Controls.Add(this.txb_bairro);
            this.Controls.Add(this.txb_cidade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_NomeSetor2);
            this.Controls.Add(this.Btn_OlharSenha);
            this.Controls.Add(this.Lbl_NivelSenha);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Lbl_NomeSetor);
            this.Controls.Add(this.Txt_ConfirmacaoSenha);
            this.Controls.Add(this.Txt_NomeUsuario);
            this.Controls.Add(this.Btn_CadastrarNovoUsuario);
            this.Controls.Add(this.Lbl_CadastroSenhaValidação);
            this.Controls.Add(this.Lbl_CadastroSenha);
            this.Controls.Add(this.Lbl_NomeUsuario);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_CadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
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
        private System.Windows.Forms.Label Lbl_NomeSetor;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_NivelSenha;
        private System.Windows.Forms.Button Btn_OlharSenha;
        private System.Windows.Forms.ComboBox Txt_NomeSetor2;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox Txt_ConfirmacaoSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txb_estado;
        private System.Windows.Forms.TextBox txb_cep;
        private System.Windows.Forms.TextBox tcbtelefone;
        private System.Windows.Forms.TextBox txb_cpf;
        private System.Windows.Forms.Label lbl_dataNasc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb_endereco;
        private System.Windows.Forms.TextBox txb_bairro;
        private System.Windows.Forms.TextBox txb_cidade;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}