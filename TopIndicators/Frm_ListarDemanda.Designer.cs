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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkbox_status = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.dtv_listarDemanda = new System.Windows.Forms.DataGridView();
            this.id_Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_Demandanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_listarDemanda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(201, 130);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(215, 28);
            this.txtPesquisa.TabIndex = 144;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkGreen;
            this.label18.Location = new System.Drawing.Point(2, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 22);
            this.label18.TabIndex = 143;
            this.label18.Text = "Pesquisar Nome:";
            // 
            // checkbox_status
            // 
            this.checkbox_status.AutoSize = true;
            this.checkbox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_status.Location = new System.Drawing.Point(1450, 143);
            this.checkbox_status.Name = "checkbox_status";
            this.checkbox_status.Size = new System.Drawing.Size(18, 17);
            this.checkbox_status.TabIndex = 142;
            this.checkbox_status.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGreen;
            this.label17.Location = new System.Drawing.Point(1327, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 32);
            this.label17.TabIndex = 141;
            this.label17.Text = "Inativas";
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
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.id_Demanda.DefaultCellStyle = dataGridViewCellStyle7;
            this.id_Demanda.HeaderText = "id_Demanda";
            this.id_Demanda.MinimumWidth = 6;
            this.id_Demanda.Name = "id_Demanda";
            this.id_Demanda.ReadOnly = true;
            this.id_Demanda.Width = 165;
            // 
            // quantidade_Demandanda
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.quantidade_Demandanda.DefaultCellStyle = dataGridViewCellStyle8;
            this.quantidade_Demandanda.HeaderText = "quantidade_Demandanda";
            this.quantidade_Demandanda.MinimumWidth = 6;
            this.quantidade_Demandanda.Name = "quantidade_Demandanda";
            this.quantidade_Demandanda.ReadOnly = true;
            this.quantidade_Demandanda.Width = 170;
            // 
            // prazo
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.prazo.DefaultCellStyle = dataGridViewCellStyle9;
            this.prazo.HeaderText = "prazo";
            this.prazo.MinimumWidth = 6;
            this.prazo.Name = "prazo";
            this.prazo.ReadOnly = true;
            this.prazo.Width = 200;
            // 
            // Cliente
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Cliente.DefaultCellStyle = dataGridViewCellStyle10;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 170;
            // 
            // Produto
            // 
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Produto.DefaultCellStyle = dataGridViewCellStyle11;
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 6;
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 170;
            // 
            // Atual
            // 
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Atual.DefaultCellStyle = dataGridViewCellStyle12;
            this.Atual.HeaderText = "Atual";
            this.Atual.MinimumWidth = 6;
            this.Atual.Name = "Atual";
            this.Atual.ReadOnly = true;
            this.Atual.Width = 180;
            // 
            // Frm_ListarDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1500, 968);
            this.Controls.Add(this.dtv_listarDemanda);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkbox_status);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Name = "Frm_ListarDemanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_ListarDemanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_listarDemanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkbox_status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridView dtv_listarDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_Demandanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atual;
    }
}