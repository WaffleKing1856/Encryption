namespace Encryption
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
            this.txt_e = new System.Windows.Forms.TextBox();
            this.btn_e = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.text_d = new System.Windows.Forms.TextBox();
            this.btn_d = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_o = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.txt_codeO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_e
            // 
            this.txt_e.Location = new System.Drawing.Point(199, 93);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(504, 20);
            this.txt_e.TabIndex = 0;
            // 
            // btn_e
            // 
            this.btn_e.Location = new System.Drawing.Point(12, 44);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(127, 79);
            this.btn_e.TabIndex = 2;
            this.btn_e.Text = "Encrypt";
            this.btn_e.UseVisualStyleBackColor = true;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message To Encrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message To Decrypt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Code";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(198, 251);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(166, 20);
            this.txt_code.TabIndex = 6;
            // 
            // text_d
            // 
            this.text_d.Location = new System.Drawing.Point(198, 208);
            this.text_d.Name = "text_d";
            this.text_d.Size = new System.Drawing.Size(504, 20);
            this.text_d.TabIndex = 8;
            // 
            // btn_d
            // 
            this.btn_d.Location = new System.Drawing.Point(12, 192);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(127, 79);
            this.btn_d.TabIndex = 9;
            this.btn_d.Text = "Decrypt";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Output : ";
            // 
            // txt_o
            // 
            this.txt_o.Location = new System.Drawing.Point(391, 344);
            this.txt_o.Multiline = true;
            this.txt_o.Name = "txt_o";
            this.txt_o.Size = new System.Drawing.Size(397, 68);
            this.txt_o.TabIndex = 11;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(310, 379);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 12;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_codeO
            // 
            this.txt_codeO.Location = new System.Drawing.Point(391, 418);
            this.txt_codeO.Name = "txt_codeO";
            this.txt_codeO.Size = new System.Drawing.Size(105, 20);
            this.txt_codeO.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Code (Encrypt Only)";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(548, 293);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(119, 45);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_codeO);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.txt_o);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.text_d);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.txt_e);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox text_d;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_o;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.TextBox txt_codeO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear;
    }
}

