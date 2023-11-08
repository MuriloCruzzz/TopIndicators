﻿namespace TopIndicators
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
            this.label13 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listView2.Location = new System.Drawing.Point(30, 166);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1458, 674);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.Frm_ListarDemanda_Load);
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
            // Frm_ListarDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1500, 968);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkbox_status);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listView2);
            this.Name = "Frm_ListarDemanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_ListarDemanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_imprimir;
    }
}