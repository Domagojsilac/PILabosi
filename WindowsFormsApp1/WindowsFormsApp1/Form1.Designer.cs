namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSpol = new System.Windows.Forms.TextBox();
            this.txtBoxBoja = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.txtBoxIspis = new System.Windows.Forms.TextBox();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUvjetBoja = new System.Windows.Forms.TextBox();
            this.txtUvjetSpol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(132, 30);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(133, 20);
            this.txtBoxIme.TabIndex = 0;
            this.txtBoxIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Boja";
            // 
            // txtBoxSpol
            // 
            this.txtBoxSpol.Location = new System.Drawing.Point(132, 70);
            this.txtBoxSpol.Name = "txtBoxSpol";
            this.txtBoxSpol.Size = new System.Drawing.Size(133, 20);
            this.txtBoxSpol.TabIndex = 4;
            // 
            // txtBoxBoja
            // 
            this.txtBoxBoja.Location = new System.Drawing.Point(132, 107);
            this.txtBoxBoja.Name = "txtBoxBoja";
            this.txtBoxBoja.Size = new System.Drawing.Size(133, 20);
            this.txtBoxBoja.TabIndex = 5;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(190, 154);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 32);
            this.btnUnos.TabIndex = 6;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // txtBoxIspis
            // 
            this.txtBoxIspis.Location = new System.Drawing.Point(132, 251);
            this.txtBoxIspis.Multiline = true;
            this.txtBoxIspis.Name = "txtBoxIspis";
            this.txtBoxIspis.Size = new System.Drawing.Size(238, 78);
            this.txtBoxIspis.TabIndex = 8;
            this.txtBoxIspis.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(16, 306);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 9;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Uvjeti za filtriranje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Boja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Spol";
            // 
            // txtUvjetBoja
            // 
            this.txtUvjetBoja.Location = new System.Drawing.Point(19, 238);
            this.txtUvjetBoja.Name = "txtUvjetBoja";
            this.txtUvjetBoja.Size = new System.Drawing.Size(100, 20);
            this.txtUvjetBoja.TabIndex = 13;
            // 
            // txtUvjetSpol
            // 
            this.txtUvjetSpol.Location = new System.Drawing.Point(19, 280);
            this.txtUvjetSpol.Name = "txtUvjetSpol";
            this.txtUvjetSpol.Size = new System.Drawing.Size(100, 20);
            this.txtUvjetSpol.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 341);
            this.Controls.Add(this.txtUvjetSpol);
            this.Controls.Add(this.txtUvjetBoja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.txtBoxIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtBoxBoja);
            this.Controls.Add(this.txtBoxSpol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSpol;
        private System.Windows.Forms.TextBox txtBoxBoja;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox txtBoxIspis;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUvjetBoja;
        private System.Windows.Forms.TextBox txtUvjetSpol;
    }
}

