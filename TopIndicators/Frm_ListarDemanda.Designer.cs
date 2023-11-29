namespace TopIndicators
{
    partial class Frm_ListarDemanda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.dtv_listarDemanda = new System.Windows.Forms.DataGridView();
            this.id_Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_Demandanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Listar_Clientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listarDemandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_listarDemanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDemandaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(513, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(564, 49);
            this.label13.TabIndex = 140;
            this.label13.Text = "CONSULTAR DEMANDAS";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.Black;
            this.btn_imprimir.Location = new System.Drawing.Point(1221, 864);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(247, 55);
            this.btn_imprimir.TabIndex = 145;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
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
            this.Cliente,
            this.Produto,
            this.Atual});
            this.dtv_listarDemanda.GridColor = System.Drawing.Color.Linen;
            this.dtv_listarDemanda.Location = new System.Drawing.Point(12, 190);
            this.dtv_listarDemanda.Name = "dtv_listarDemanda";
            this.dtv_listarDemanda.ReadOnly = true;
            this.dtv_listarDemanda.RowHeadersWidth = 51;
            this.dtv_listarDemanda.RowTemplate.Height = 24;
            this.dtv_listarDemanda.Size = new System.Drawing.Size(1476, 647);
            this.dtv_listarDemanda.TabIndex = 146;
            this.dtv_listarDemanda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_listarDemanda_CellContentDoubleClick);
            // 
            // id_Demanda
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.id_Demanda.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_Demanda.HeaderText = "id_Demanda";
            this.id_Demanda.MinimumWidth = 6;
            this.id_Demanda.Name = "id_Demanda";
            this.id_Demanda.ReadOnly = true;
            this.id_Demanda.Width = 165;
            // 
            // quantidade_Demandanda
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.quantidade_Demandanda.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantidade_Demandanda.HeaderText = "quantidade_Demandanda";
            this.quantidade_Demandanda.MinimumWidth = 6;
            this.quantidade_Demandanda.Name = "quantidade_Demandanda";
            this.quantidade_Demandanda.ReadOnly = true;
            this.quantidade_Demandanda.Width = 170;
            // 
            // prazo
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.prazo.DefaultCellStyle = dataGridViewCellStyle3;
            this.prazo.HeaderText = "prazo";
            this.prazo.MinimumWidth = 6;
            this.prazo.Name = "prazo";
            this.prazo.ReadOnly = true;
            this.prazo.Width = 200;
            // 
            // Cliente
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Cliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 170;
            // 
            // Produto
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Produto.DefaultCellStyle = dataGridViewCellStyle5;
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 6;
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 170;
            // 
            // Atual
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Atual.DefaultCellStyle = dataGridViewCellStyle6;
            this.Atual.HeaderText = "Atual";
            this.Atual.MinimumWidth = 6;
            this.Atual.Name = "Atual";
            this.Atual.ReadOnly = true;
            this.Atual.Width = 180;
            // 
            // Listar_Clientes
            // 
            this.Listar_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listar_Clientes.FormattingEnabled = true;
            this.Listar_Clientes.Location = new System.Drawing.Point(171, 150);
            this.Listar_Clientes.Name = "Listar_Clientes";
            this.Listar_Clientes.Size = new System.Drawing.Size(244, 26);
            this.Listar_Clientes.TabIndex = 148;
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
            this.label6.Location = new System.Drawing.Point(62, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 147;
            this.label6.Text = "CLIENTE";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(681, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 28);
            this.comboBox1.TabIndex = 150;
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
            this.label5.Location = new System.Drawing.Point(456, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 149;
            this.label5.Text = "PRODUTO FINAL";
            // 
            // listarDemandaBindingSource
            // 
            this.listarDemandaBindingSource.DataSource = typeof(ListagemDemanda.ListarDemanda);
            this.listarDemandaBindingSource.CurrentChanged += new System.EventHandler(this.listarDemandaBindingSource_CurrentChanged);
            // 
            // Frm_ListarDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1500, 968);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Listar_Clientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtv_listarDemanda);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.label13);
            this.Name = "Frm_ListarDemanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_ListarDemanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_listarDemanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDemandaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridView dtv_listarDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_Demandanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atual;
        private System.Windows.Forms.BindingSource listarDemandaBindingSource;
        protected System.Windows.Forms.ComboBox Listar_Clientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}