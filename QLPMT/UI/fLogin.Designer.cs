namespace UI
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(53, 168);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(89, 46);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(280, 168);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 46);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(132, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu :";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(53, 79);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(342, 20);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Text = "staff";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(53, 125);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(342, 20);
            this.textBoxPassWord.TabIndex = 2;
            this.textBoxPassWord.Text = "staff";
            this.textBoxPassWord.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.textBoxPassWord);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Location = new System.Drawing.Point(53, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 236);
            this.panel1.TabIndex = 5;
            // 
            // fLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(529, 341);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý quán cà phê";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Panel panel1;
    }
}

