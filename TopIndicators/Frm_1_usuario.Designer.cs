namespace TopIndicators
{
    partial class Frm_1_usuario
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkbox_status = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtv_colaboradores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Nasc_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_colaboradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(220, 32);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(215, 28);
            this.txtPesquisa.TabIndex = 139;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkGreen;
            this.label18.Location = new System.Drawing.Point(21, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 22);
            this.label18.TabIndex = 138;
            this.label18.Text = "Pesquisar Nome:";
            // 
            // checkbox_status
            // 
            this.checkbox_status.AutoSize = true;
            this.checkbox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_status.Location = new System.Drawing.Point(1469, 45);
            this.checkbox_status.Name = "checkbox_status";
            this.checkbox_status.Size = new System.Drawing.Size(18, 17);
            this.checkbox_status.TabIndex = 136;
            this.checkbox_status.UseVisualStyleBackColor = true;
            this.checkbox_status.CheckedChanged += new System.EventHandler(this.checkbox_status_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGreen;
            this.label17.Location = new System.Drawing.Point(1346, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 32);
            this.label17.TabIndex = 135;
            this.label17.Text = "Inativos";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(1240, 849);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(247, 55);
            this.btn_imprimir.TabIndex = 101;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(588, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(430, 49);
            this.label13.TabIndex = 102;
            this.label13.Text = "Consulta Usuarios";
            // 
            // dtv_colaboradores
            // 
            this.dtv_colaboradores.AllowUserToAddRows = false;
            this.dtv_colaboradores.AllowUserToDeleteRows = false;
            this.dtv_colaboradores.AllowUserToResizeColumns = false;
            this.dtv_colaboradores.AllowUserToResizeRows = false;
            this.dtv_colaboradores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtv_colaboradores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtv_colaboradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtv_colaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_colaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.id_setor,
            this.senha,
            this.Cargo,
            this.Turno,
            this.Cpf_Usuario,
            this.Telefone_Usuario,
            this.Email_Usuario,
            this.Data_Nasc_Usuario,
            this.Endereco_Usuario,
            this.Bairro_Usuario,
            this.Estado_Usuario,
            this.Cidade_Usuario,
            this.Cep_Usuario});
            this.dtv_colaboradores.GridColor = System.Drawing.Color.Khaki;
            this.dtv_colaboradores.Location = new System.Drawing.Point(17, 69);
            this.dtv_colaboradores.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_colaboradores.Name = "dtv_colaboradores";
            this.dtv_colaboradores.ReadOnly = true;
            this.dtv_colaboradores.RowHeadersWidth = 51;
            this.dtv_colaboradores.Size = new System.Drawing.Size(1470, 772);
            this.dtv_colaboradores.TabIndex = 100;
            this.dtv_colaboradores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_colaboradores_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Registro";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // id_setor
            // 
            this.id_setor.HeaderText = "Setor";
            this.id_setor.MinimumWidth = 6;
            this.id_setor.Name = "id_setor";
            this.id_setor.ReadOnly = true;
            this.id_setor.Width = 125;
            // 
            // senha
            // 
            this.senha.HeaderText = "senha";
            this.senha.MinimumWidth = 6;
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            this.senha.Width = 125;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 125;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.MinimumWidth = 6;
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            this.Turno.Width = 125;
            // 
            // Cpf_Usuario
            // 
            this.Cpf_Usuario.HeaderText = "CPF";
            this.Cpf_Usuario.MinimumWidth = 6;
            this.Cpf_Usuario.Name = "Cpf_Usuario";
            this.Cpf_Usuario.ReadOnly = true;
            this.Cpf_Usuario.Width = 125;
            // 
            // Telefone_Usuario
            // 
            this.Telefone_Usuario.HeaderText = "Telefone";
            this.Telefone_Usuario.MinimumWidth = 6;
            this.Telefone_Usuario.Name = "Telefone_Usuario";
            this.Telefone_Usuario.ReadOnly = true;
            this.Telefone_Usuario.Width = 125;
            // 
            // Email_Usuario
            // 
            this.Email_Usuario.HeaderText = "Email";
            this.Email_Usuario.MinimumWidth = 6;
            this.Email_Usuario.Name = "Email_Usuario";
            this.Email_Usuario.ReadOnly = true;
            this.Email_Usuario.Width = 125;
            // 
            // Data_Nasc_Usuario
            // 
            this.Data_Nasc_Usuario.HeaderText = "Data Nascimento";
            this.Data_Nasc_Usuario.MinimumWidth = 6;
            this.Data_Nasc_Usuario.Name = "Data_Nasc_Usuario";
            this.Data_Nasc_Usuario.ReadOnly = true;
            this.Data_Nasc_Usuario.Width = 125;
            // 
            // Endereco_Usuario
            // 
            this.Endereco_Usuario.HeaderText = "Endereco";
            this.Endereco_Usuario.MinimumWidth = 6;
            this.Endereco_Usuario.Name = "Endereco_Usuario";
            this.Endereco_Usuario.ReadOnly = true;
            this.Endereco_Usuario.Width = 125;
            // 
            // Bairro_Usuario
            // 
            this.Bairro_Usuario.HeaderText = "Bairro";
            this.Bairro_Usuario.MinimumWidth = 6;
            this.Bairro_Usuario.Name = "Bairro_Usuario";
            this.Bairro_Usuario.ReadOnly = true;
            this.Bairro_Usuario.Width = 125;
            // 
            // Estado_Usuario
            // 
            this.Estado_Usuario.HeaderText = "Estado";
            this.Estado_Usuario.MinimumWidth = 6;
            this.Estado_Usuario.Name = "Estado_Usuario";
            this.Estado_Usuario.ReadOnly = true;
            this.Estado_Usuario.Width = 125;
            // 
            // Cidade_Usuario
            // 
            this.Cidade_Usuario.HeaderText = "Cidade";
            this.Cidade_Usuario.MinimumWidth = 6;
            this.Cidade_Usuario.Name = "Cidade_Usuario";
            this.Cidade_Usuario.ReadOnly = true;
            this.Cidade_Usuario.Width = 125;
            // 
            // Cep_Usuario
            // 
            this.Cep_Usuario.HeaderText = "CEP";
            this.Cep_Usuario.MinimumWidth = 6;
            this.Cep_Usuario.Name = "Cep_Usuario";
            this.Cep_Usuario.ReadOnly = true;
            this.Cep_Usuario.Width = 125;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(DadosUsuarios.Usuario);
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataSource = typeof(DadosUsuarios.Usuario);
            // 
            // Frm_1_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1509, 917);
            this.Controls.Add(this.dtv_colaboradores);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkbox_status);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.label13);
            this.Name = "Frm_1_usuario";
            this.Text = "Frm_1_usuario";
            this.Load += new System.EventHandler(this.Frm_1_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_colaboradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkbox_status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtv_colaboradores;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Nasc_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep_Usuario;
    }
}