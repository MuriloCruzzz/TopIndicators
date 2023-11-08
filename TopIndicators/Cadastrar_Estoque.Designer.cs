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
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.btn_importarMP = new System.Windows.Forms.Button();
            this.btn_Importar_MT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prazo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkbox_status = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
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
            this.btn_importarMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importarMP.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_importarMP.Location = new System.Drawing.Point(12, 936);
            this.btn_importarMP.Name = "btn_importarMP";
            this.btn_importarMP.Size = new System.Drawing.Size(456, 36);
            this.btn_importarMP.TabIndex = 2;
            this.btn_importarMP.Text = "IMPORTAR TABELA DE MATERIA PRIMA";
            this.btn_importarMP.UseVisualStyleBackColor = false;
            this.btn_importarMP.Click += new System.EventHandler(this.btn_importarMP_Click);
            // 
            // btn_Importar_MT
            // 
            this.btn_Importar_MT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Importar_MT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Importar_MT.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Importar_MT.Location = new System.Drawing.Point(485, 936);
            this.btn_Importar_MT.Name = "btn_Importar_MT";
            this.btn_Importar_MT.Size = new System.Drawing.Size(454, 36);
            this.btn_Importar_MT.TabIndex = 3;
            this.btn_Importar_MT.Text = "IMPORTAR TABELA DE MATERIAIS";
            this.btn_Importar_MT.UseVisualStyleBackColor = false;
            this.btn_Importar_MT.Click += new System.EventHandler(this.btn_Importar_MT_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(169, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = " MATERIA PRIMA";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(1046, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "MATERIAIS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Quantidade,
            this.Prazo,
            this.Status,
            this.Id_Cliente,
            this.Id_Produto,
            this.Id_Usuario});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 298);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1460, 609);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 120;
            // 
            // Prazo
            // 
            this.Prazo.Text = "Prazo";
            this.Prazo.Width = 110;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 80;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.Text = "Id_Cliente";
            // 
            // Id_Produto
            // 
            this.Id_Produto.Text = "Id_Produto";
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.Text = "Id_Usuario";
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
            // Cadastrar_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1503, 1014);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkbox_status);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Importar_MT);
            this.Controls.Add(this.btn_importarMP);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Name = "Cadastrar_Estoque";
            this.Text = "Cadastrar_Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Cadastro;
        private System.Windows.Forms.Button btn_importarMP;
        private System.Windows.Forms.Button btn_Importar_MT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Prazo;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Id_Cliente;
        private System.Windows.Forms.ColumnHeader Id_Produto;
        private System.Windows.Forms.ColumnHeader Id_Usuario;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkbox_status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_imprimir;
    }
}