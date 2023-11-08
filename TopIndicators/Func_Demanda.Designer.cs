namespace TopIndicators
{
    partial class Func_Demanda
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(22, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "NOVA DEMANDA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(3, 939);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 68);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(321, 939);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 68);
            this.panel1.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(16, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "LISTAR DEMANDAS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1576, 928);
            this.panel3.TabIndex = 13;
            // 
            // Func_Demanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Func_Demanda";
            this.Text = "Func_Demanda";
            this.Load += new System.EventHandler(this.Func_Demanda_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
    }
}