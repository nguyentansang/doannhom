namespace doan2
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
            this.b = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(386, 206);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 23);
            this.b.TabIndex = 12;
            this.b.Text = "thoát";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(216, 206);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(75, 23);
            this.a.TabIndex = 11;
            this.a.Text = "đăng nhập";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "tài khoản";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(297, 128);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 20);
            this.n.TabIndex = 8;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(297, 68);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(100, 20);
            this.m.TabIndex = 7;
            this.m.TextChanged += new System.EventHandler(this.m_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 296);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.m);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox m;
    }
}

