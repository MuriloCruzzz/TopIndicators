namespace TopIndicators
{
    partial class AdicionarEstoque
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
            this.lbl_nome_produto = new System.Windows.Forms.Label();
            this.Lbl_nomeProd = new System.Windows.Forms.Label();
            this.mk_quantidadeADC = new System.Windows.Forms.MaskedTextBox();
            this.lb_quantidade = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome_produto
            // 
            this.lbl_nome_produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nome_produto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nome_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_produto.ForeColor = System.Drawing.Color.Blue;
            this.lbl_nome_produto.Location = new System.Drawing.Point(417, 36);
            this.lbl_nome_produto.Name = "lbl_nome_produto";
            this.lbl_nome_produto.Size = new System.Drawing.Size(354, 61);
            this.lbl_nome_produto.TabIndex = 4;
            this.lbl_nome_produto.Text = "Nome Produto";
            // 
            // Lbl_nomeProd
            // 
            this.Lbl_nomeProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_nomeProd.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nomeProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_nomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nomeProd.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_nomeProd.Location = new System.Drawing.Point(9, 34);
            this.Lbl_nomeProd.Name = "Lbl_nomeProd";
            this.Lbl_nomeProd.Size = new System.Drawing.Size(423, 61);
            this.Lbl_nomeProd.TabIndex = 3;
            this.Lbl_nomeProd.Text = "Comp/MP:";
            this.Lbl_nomeProd.Click += new System.EventHandler(this.Lbl_Cadastro_Click);
            // 
            // mk_quantidadeADC
            // 
            this.mk_quantidadeADC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mk_quantidadeADC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mk_quantidadeADC.Location = new System.Drawing.Point(284, 141);
            this.mk_quantidadeADC.Mask = "000000000";
            this.mk_quantidadeADC.Name = "mk_quantidadeADC";
            this.mk_quantidadeADC.Size = new System.Drawing.Size(168, 41);
            this.mk_quantidadeADC.TabIndex = 5;
            this.mk_quantidadeADC.ValidatingType = typeof(int);
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_quantidade.BackColor = System.Drawing.Color.Transparent;
            this.lb_quantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantidade.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_quantidade.Location = new System.Drawing.Point(14, 136);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(307, 61);
            this.lb_quantidade.TabIndex = 6;
            this.lb_quantidade.Text = "Quantidade:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(650, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(88, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlueViolet;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(526, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "REMOVER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdicionarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_nome_produto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mk_quantidadeADC);
            this.Controls.Add(this.lb_quantidade);
            this.Controls.Add(this.Lbl_nomeProd);
            this.Name = "AdicionarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarEstoque";
            this.Load += new System.EventHandler(this.AdicionarEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_produto;
        private System.Windows.Forms.Label Lbl_nomeProd;
        private System.Windows.Forms.MaskedTextBox mk_quantidadeADC;
        private System.Windows.Forms.Label lb_quantidade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}