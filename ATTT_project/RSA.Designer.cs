namespace ATTT_project
{
    partial class RSA
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
            this.txtplaintext = new System.Windows.Forms.RichTextBox();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtplaintext
            // 
            this.txtplaintext.Location = new System.Drawing.Point(45, 51);
            this.txtplaintext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtplaintext.Name = "txtplaintext";
            this.txtplaintext.Size = new System.Drawing.Size(389, 219);
            this.txtplaintext.TabIndex = 0;
            this.txtplaintext.Text = "";
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(577, 47);
            this.txt_p.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(148, 26);
            this.txt_p.TabIndex = 1;
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(577, 99);
            this.txt_q.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(148, 26);
            this.txt_q.TabIndex = 2;
            // 
            // txt_e
            // 
            this.txt_e.Location = new System.Drawing.Point(577, 203);
            this.txt_e.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(148, 26);
            this.txt_e.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "e";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mã hoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "d";
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(577, 255);
            this.txt_d.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(148, 26);
            this.txt_d.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "n";
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(577, 151);
            this.txt_n.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(148, 26);
            this.txt_n.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(577, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 469);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_e);
            this.Controls.Add(this.txt_q);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.txtplaintext);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RSA";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.RSA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtplaintext;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}