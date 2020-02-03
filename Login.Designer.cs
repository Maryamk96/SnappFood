namespace SnappFood
{
    partial class Login
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
            this.textuser = new System.Windows.Forms.TextBox();
            this.enterbtn = new System.Windows.Forms.Button();
            this.textpass = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.RadioButton();
            this.notuser = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(22, 17);
            this.textuser.Multiline = true;
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(241, 36);
            this.textuser.TabIndex = 0;
            // 
            // enterbtn
            // 
            this.enterbtn.BackgroundImage = global::SnappFood.Properties.Resources.IMG_20190209_004128_483;
            this.enterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterbtn.Location = new System.Drawing.Point(162, 214);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(101, 34);
            this.enterbtn.TabIndex = 1;
            this.enterbtn.Text = "ورود";
            this.enterbtn.UseVisualStyleBackColor = true;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(22, 80);
            this.textpass.Multiline = true;
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(241, 36);
            this.textpass.TabIndex = 2;
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = global::SnappFood.Properties.Resources.IMG_20190209_004128_483;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Location = new System.Drawing.Point(22, 265);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(241, 34);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "عضویت";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Checked = true;
            this.user.Font = new System.Drawing.Font("2  Bardiya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.user.Location = new System.Drawing.Point(162, 160);
            this.user.Name = "user";
            this.user.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user.Size = new System.Drawing.Size(98, 36);
            this.user.TabIndex = 4;
            this.user.TabStop = true;
            this.user.Text = "عضو هستم";
            this.user.UseVisualStyleBackColor = true;
            this.user.CheckedChanged += new System.EventHandler(this.user_CheckedChanged);
            // 
            // notuser
            // 
            this.notuser.AutoSize = true;
            this.notuser.Font = new System.Drawing.Font("2  Bardiya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.notuser.Location = new System.Drawing.Point(11, 160);
            this.notuser.Name = "notuser";
            this.notuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notuser.Size = new System.Drawing.Size(142, 36);
            this.notuser.TabIndex = 5;
            this.notuser.TabStop = true;
            this.notuser.Text = "میخواهم عضو شوم";
            this.notuser.UseVisualStyleBackColor = true;
            this.notuser.CheckedChanged += new System.EventHandler(this.notuser_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Bardiya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(280, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام کاربری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("2  Bardiya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(280, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "رمز عبور";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SnappFood.Properties.Resources.IMG_20190209_004128_483;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(22, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.enterbtn);
            this.groupBox1.Controls.Add(this.notuser);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.textpass);
            this.groupBox1.Controls.Add(this.textuser);
            this.groupBox1.Location = new System.Drawing.Point(278, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 318);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SnappFood.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 360);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.RadioButton notuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}