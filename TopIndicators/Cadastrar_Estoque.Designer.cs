﻿namespace TopIndicators
{
    partial class Cadastrar_Estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.btn_importarMP = new System.Windows.Forms.Button();
            this.btn_Importar_MT = new System.Windows.Forms.Button();
            this.btn_Listar_materiaPrima = new System.Windows.Forms.Button();
            this.btn_Listar_Materiais = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkbox_status = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque_Atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Lbl_Cadastro.Location = new System.Drawing.Point(473, 34);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(547, 99);
            this.Lbl_Cadastro.TabIndex = 1;
            this.Lbl_Cadastro.Text = "ESTOQUE";
            this.Lbl_Cadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_importarMP
            // 
            this.btn_importarMP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_importarMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importarMP.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_importarMP.Location = new System.Drawing.Point(12, 946);
            this.btn_importarMP.Name = "btn_importarMP";
            this.btn_importarMP.Size = new System.Drawing.Size(382, 36);
            this.btn_importarMP.TabIndex = 2;
            this.btn_importarMP.Text = "IMPORTAR TABELA DE MATERIA PRIMA";
            this.btn_importarMP.UseVisualStyleBackColor = false;
            this.btn_importarMP.Click += new System.EventHandler(this.btn_importarMP_Click);
            // 
            // btn_Importar_MT
            // 
            this.btn_Importar_MT.BackColor = System.Drawing.Color.Purple;
            this.btn_Importar_MT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Importar_MT.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Importar_MT.Location = new System.Drawing.Point(413, 947);
            this.btn_Importar_MT.Name = "btn_Importar_MT";
            this.btn_Importar_MT.Size = new System.Drawing.Size(359, 36);
            this.btn_Importar_MT.TabIndex = 3;
            this.btn_Importar_MT.Text = "IMPORTAR TABELA DE MATERIAIS";
            this.btn_Importar_MT.UseVisualStyleBackColor = false;
            this.btn_Importar_MT.Click += new System.EventHandler(this.btn_Importar_MT_Click);
            // 
            // btn_Listar_materiaPrima
            // 
            this.btn_Listar_materiaPrima.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Listar_materiaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar_materiaPrima.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Listar_materiaPrima.Location = new System.Drawing.Point(169, 138);
            this.btn_Listar_materiaPrima.Name = "btn_Listar_materiaPrima";
            this.btn_Listar_materiaPrima.Size = new System.Drawing.Size(266, 47);
            this.btn_Listar_materiaPrima.TabIndex = 4;
            this.btn_Listar_materiaPrima.Text = " MATERIA PRIMA";
            this.btn_Listar_materiaPrima.UseVisualStyleBackColor = false;
            this.btn_Listar_materiaPrima.Click += new System.EventHandler(this.btn_Listar_materiaPrima_Click);
            // 
            // btn_Listar_Materiais
            // 
            this.btn_Listar_Materiais.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Listar_Materiais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar_Materiais.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Listar_Materiais.Location = new System.Drawing.Point(1046, 138);
            this.btn_Listar_Materiais.Name = "btn_Listar_Materiais";
            this.btn_Listar_Materiais.Size = new System.Drawing.Size(266, 47);
            this.btn_Listar_Materiais.TabIndex = 5;
            this.btn_Listar_Materiais.Text = "MATERIAIS";
            this.btn_Listar_Materiais.UseVisualStyleBackColor = false;
            this.btn_Listar_Materiais.Click += new System.EventHandler(this.btn_Listar_Materiais_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(223, 250);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(215, 28);
            this.txtPesquisa.TabIndex = 143;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkGreen;
            this.label18.Location = new System.Drawing.Point(24, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 22);
            this.label18.TabIndex = 142;
            this.label18.Text = "Pesquisar Nome:";
            // 
            // checkbox_status
            // 
            this.checkbox_status.AutoSize = true;
            this.checkbox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_status.Location = new System.Drawing.Point(1455, 265);
            this.checkbox_status.Name = "checkbox_status";
            this.checkbox_status.Size = new System.Drawing.Size(18, 17);
            this.checkbox_status.TabIndex = 141;
            this.checkbox_status.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGreen;
            this.label17.Location = new System.Drawing.Point(1312, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 32);
            this.label17.TabIndex = 140;
            this.label17.Text = "Inativos";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.Black;
            this.btn_imprimir.Location = new System.Drawing.Point(1225, 936);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(247, 55);
            this.btn_imprimir.TabIndex = 144;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.nome,
            this.Validade,
            this.Estoque_Atual,
            this.Minimo,
            this.Maximo,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(28, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1445, 578);
            this.dataGridView1.TabIndex = 145;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // id_produto
            // 
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            this.id_produto.DefaultCellStyle = dataGridViewCellStyle43;
            this.id_produto.HeaderText = "id_produto";
            this.id_produto.MinimumWidth = 6;
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 145;
            // 
            // nome
            // 
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Black;
            this.nome.DefaultCellStyle = dataGridViewCellStyle44;
            this.nome.HeaderText = "nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 145;
            // 
            // Validade
            // 
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black;
            this.Validade.DefaultCellStyle = dataGridViewCellStyle45;
            this.Validade.HeaderText = "Validade";
            this.Validade.MinimumWidth = 6;
            this.Validade.Name = "Validade";
            this.Validade.ReadOnly = true;
            this.Validade.Width = 145;
            // 
            // Estoque_Atual
            // 
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Black;
            this.Estoque_Atual.DefaultCellStyle = dataGridViewCellStyle46;
            this.Estoque_Atual.HeaderText = "Estoque_Atual";
            this.Estoque_Atual.MinimumWidth = 6;
            this.Estoque_Atual.Name = "Estoque_Atual";
            this.Estoque_Atual.ReadOnly = true;
            this.Estoque_Atual.Width = 145;
            // 
            // Minimo
            // 
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.Black;
            this.Minimo.DefaultCellStyle = dataGridViewCellStyle47;
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.MinimumWidth = 6;
            this.Minimo.Name = "Minimo";
            this.Minimo.ReadOnly = true;
            this.Minimo.Width = 145;
            // 
            // Maximo
            // 
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Black;
            this.Maximo.DefaultCellStyle = dataGridViewCellStyle48;
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.MinimumWidth = 6;
            this.Maximo.Name = "Maximo";
            this.Maximo.ReadOnly = true;
            this.Maximo.Width = 145;
            // 
            // Status
            // 
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.Black;
            this.Status.DefaultCellStyle = dataGridViewCellStyle49;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 160;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(794, 946);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 36);
            this.button1.TabIndex = 146;
            this.button1.Text = "IMPORTAR E.PRODUTO ACABADO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastrar_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1503, 1014);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkbox_status);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_Listar_Materiais);
            this.Controls.Add(this.btn_Listar_materiaPrima);
            this.Controls.Add(this.btn_Importar_MT);
            this.Controls.Add(this.btn_importarMP);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Name = "Cadastrar_Estoque";
            this.Text = "Cadastrar_Estoque";
            this.Load += new System.EventHandler(this.Cadastrar_Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Cadastro;
        private System.Windows.Forms.Button btn_importarMP;
        private System.Windows.Forms.Button btn_Importar_MT;
        private System.Windows.Forms.Button btn_Listar_materiaPrima;
        private System.Windows.Forms.Button btn_Listar_Materiais;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkbox_status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button button1;
    }
}