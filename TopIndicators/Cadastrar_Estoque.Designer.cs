namespace TopIndicators
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.btn_importarMP = new System.Windows.Forms.Button();
            this.btn_Importar_MT = new System.Windows.Forms.Button();
            this.btn_Listar_materiaPrima = new System.Windows.Forms.Button();
            this.btn_Listar_Materiais = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_produtoAcabado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Lbl_Cadastro.Location = new System.Drawing.Point(491, 36);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(547, 99);
            this.Lbl_Cadastro.TabIndex = 1;
            this.Lbl_Cadastro.Text = "ESTOQUE";
            this.Lbl_Cadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_importarMP
            // 
            this.btn_importarMP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_importarMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importarMP.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_importarMP.Location = new System.Drawing.Point(12, 948);
            this.btn_importarMP.Name = "btn_importarMP";
            this.btn_importarMP.Size = new System.Drawing.Size(257, 36);
            this.btn_importarMP.TabIndex = 2;
            this.btn_importarMP.Text = "IMPORTAR MATERIA PRIMA";
            this.btn_importarMP.UseVisualStyleBackColor = false;
            this.btn_importarMP.Click += new System.EventHandler(this.btn_importarMP_Click);
            // 
            // btn_Importar_MT
            // 
            this.btn_Importar_MT.BackColor = System.Drawing.Color.Purple;
            this.btn_Importar_MT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Importar_MT.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Importar_MT.Location = new System.Drawing.Point(298, 948);
            this.btn_Importar_MT.Name = "btn_Importar_MT";
            this.btn_Importar_MT.Size = new System.Drawing.Size(257, 36);
            this.btn_Importar_MT.TabIndex = 3;
            this.btn_Importar_MT.Text = "IMPORTAR COMPONENTES";
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
            this.btn_Listar_Materiais.Location = new System.Drawing.Point(643, 138);
            this.btn_Listar_Materiais.Name = "btn_Listar_Materiais";
            this.btn_Listar_Materiais.Size = new System.Drawing.Size(266, 47);
            this.btn_Listar_Materiais.TabIndex = 5;
            this.btn_Listar_Materiais.Text = "COMPONENTES";
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
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
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
            this.btn_imprimir.Visible = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(1445, 618);
            this.dataGridView1.TabIndex = 145;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // id_produto
            // 
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            this.id_produto.DefaultCellStyle = dataGridViewCellStyle36;
            this.id_produto.HeaderText = "id_produto";
            this.id_produto.MinimumWidth = 6;
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 129;
            // 
            // nome
            // 
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            this.nome.DefaultCellStyle = dataGridViewCellStyle37;
            this.nome.HeaderText = "nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 145;
            // 
            // Validade
            // 
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black;
            this.Validade.DefaultCellStyle = dataGridViewCellStyle38;
            this.Validade.HeaderText = "Validade";
            this.Validade.MinimumWidth = 6;
            this.Validade.Name = "Validade";
            this.Validade.ReadOnly = true;
            this.Validade.Width = 145;
            // 
            // Estoque_Atual
            // 
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black;
            this.Estoque_Atual.DefaultCellStyle = dataGridViewCellStyle39;
            this.Estoque_Atual.HeaderText = "Estoque_Atual";
            this.Estoque_Atual.MinimumWidth = 6;
            this.Estoque_Atual.Name = "Estoque_Atual";
            this.Estoque_Atual.ReadOnly = true;
            this.Estoque_Atual.Width = 145;
            // 
            // Minimo
            // 
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            this.Minimo.DefaultCellStyle = dataGridViewCellStyle40;
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.MinimumWidth = 6;
            this.Minimo.Name = "Minimo";
            this.Minimo.ReadOnly = true;
            this.Minimo.Width = 145;
            // 
            // Maximo
            // 
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            this.Maximo.DefaultCellStyle = dataGridViewCellStyle41;
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.MinimumWidth = 6;
            this.Maximo.Name = "Maximo";
            this.Maximo.ReadOnly = true;
            this.Maximo.Width = 145;
            // 
            // Status
            // 
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            this.Status.DefaultCellStyle = dataGridViewCellStyle42;
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
            this.button1.Location = new System.Drawing.Point(577, 948);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 36);
            this.button1.TabIndex = 146;
            this.button1.Text = "IMPORTAR E.PRODUTO ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(855, 948);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 36);
            this.button2.TabIndex = 147;
            this.button2.Text = "IMPORTAR CLIENTES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_produtoAcabado
            // 
            this.btn_produtoAcabado.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_produtoAcabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtoAcabado.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_produtoAcabado.Location = new System.Drawing.Point(1109, 138);
            this.btn_produtoAcabado.Name = "btn_produtoAcabado";
            this.btn_produtoAcabado.Size = new System.Drawing.Size(266, 47);
            this.btn_produtoAcabado.TabIndex = 148;
            this.btn_produtoAcabado.Text = "PRODUTO AC";
            this.btn_produtoAcabado.UseVisualStyleBackColor = false;
            this.btn_produtoAcabado.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::TopIndicators.Properties.Resources.olhar1;
            this.label1.Location = new System.Drawing.Point(1118, 960);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 149;
            this.label1.Tag = "      ";
            this.label1.Text = "          ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cadastrar_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1503, 1014);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_produtoAcabado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label18);
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
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_produtoAcabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
    }
}