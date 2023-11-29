namespace TopIndicators
{
    partial class Frm_Cadastrar_Linha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtv_listarDemanda = new System.Windows.Forms.DataGridView();
            this.id_Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_Demandanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listarDemandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Listar_Clientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_listarDemanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDemandaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(372, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 69);
            this.label1.TabIndex = 24;
            this.label1.Text = "NOVA LINHA PRODUÇÃO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(652, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "DEMANDAS";
            // 
            // dtv_listarDemanda
            // 
            this.dtv_listarDemanda.AllowUserToAddRows = false;
            this.dtv_listarDemanda.AllowUserToDeleteRows = false;
            this.dtv_listarDemanda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtv_listarDemanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_listarDemanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Demanda,
            this.quantidade_Demandanda,
            this.prazo,
            this.nome_cliente,
            this.nome_produto,
            this.Atual});
            this.dtv_listarDemanda.GridColor = System.Drawing.Color.Linen;
            this.dtv_listarDemanda.Location = new System.Drawing.Point(22, 187);
            this.dtv_listarDemanda.Name = "dtv_listarDemanda";
            this.dtv_listarDemanda.ReadOnly = true;
            this.dtv_listarDemanda.RowHeadersWidth = 51;
            this.dtv_listarDemanda.RowTemplate.Height = 24;
            this.dtv_listarDemanda.Size = new System.Drawing.Size(1476, 723);
            this.dtv_listarDemanda.TabIndex = 149;
            this.dtv_listarDemanda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_listarDemanda_CellContentDoubleClick);
            // 
            // id_Demanda
            // 
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.id_Demanda.DefaultCellStyle = dataGridViewCellStyle13;
            this.id_Demanda.HeaderText = "id_Demanda";
            this.id_Demanda.MinimumWidth = 6;
            this.id_Demanda.Name = "id_Demanda";
            this.id_Demanda.ReadOnly = true;
            this.id_Demanda.Width = 165;
            // 
            // quantidade_Demandanda
            // 
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.quantidade_Demandanda.DefaultCellStyle = dataGridViewCellStyle14;
            this.quantidade_Demandanda.HeaderText = "quantidade_Demandanda";
            this.quantidade_Demandanda.MinimumWidth = 6;
            this.quantidade_Demandanda.Name = "quantidade_Demandanda";
            this.quantidade_Demandanda.ReadOnly = true;
            this.quantidade_Demandanda.Width = 170;
            // 
            // prazo
            // 
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.prazo.DefaultCellStyle = dataGridViewCellStyle15;
            this.prazo.HeaderText = "prazo";
            this.prazo.MinimumWidth = 6;
            this.prazo.Name = "prazo";
            this.prazo.ReadOnly = true;
            this.prazo.Width = 200;
            // 
            // nome_cliente
            // 
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.nome_cliente.DefaultCellStyle = dataGridViewCellStyle16;
            this.nome_cliente.HeaderText = "nome_cliente";
            this.nome_cliente.MinimumWidth = 6;
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            this.nome_cliente.Width = 170;
            // 
            // nome_produto
            // 
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.nome_produto.DefaultCellStyle = dataGridViewCellStyle17;
            this.nome_produto.HeaderText = "nome_produto";
            this.nome_produto.MinimumWidth = 6;
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            this.nome_produto.Width = 170;
            // 
            // Atual
            // 
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.Atual.DefaultCellStyle = dataGridViewCellStyle18;
            this.Atual.HeaderText = "Atual";
            this.Atual.MinimumWidth = 6;
            this.Atual.Name = "Atual";
            this.Atual.ReadOnly = true;
            this.Atual.Width = 180;
            // 
            // listarDemandaBindingSource
            // 
            this.listarDemandaBindingSource.DataSource = typeof(ListagemDemanda.ListarDemanda);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(659, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 28);
            this.comboBox1.TabIndex = 154;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(434, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 153;
            this.label5.Text = "PRODUTO FINAL";
            // 
            // Listar_Clientes
            // 
            this.Listar_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listar_Clientes.FormattingEnabled = true;
            this.Listar_Clientes.Location = new System.Drawing.Point(149, 149);
            this.Listar_Clientes.Name = "Listar_Clientes";
            this.Listar_Clientes.Size = new System.Drawing.Size(244, 26);
            this.Listar_Clientes.TabIndex = 152;
            this.Listar_Clientes.SelectedIndexChanged += new System.EventHandler(this.Listar_Clientes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(40, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 151;
            this.label6.Text = "CLIENTE";
            // 
            // Frm_Cadastrar_Linha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1531, 961);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Listar_Clientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtv_listarDemanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Cadastrar_Linha";
            this.Text = "Frm_Cadastrar_Linha";
            this.Load += new System.EventHandler(this.Frm_Cadastrar_Linha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_listarDemanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDemandaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtv_listarDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_Demandanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atual;
        private System.Windows.Forms.BindingSource listarDemandaBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.ComboBox Listar_Clientes;
        private System.Windows.Forms.Label label6;
    }
}