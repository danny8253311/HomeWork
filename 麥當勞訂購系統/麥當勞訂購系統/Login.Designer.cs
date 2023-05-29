namespace 麥當勞訂購系統
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox帳號 = new System.Windows.Forms.TextBox();
            this.txtBox密碼 = new System.Windows.Forms.TextBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn註冊會員 = new System.Windows.Forms.Button();
            this.btn免註冊訂餐 = new System.Windows.Forms.Button();
            this.chB管理登入 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "cDonald\'s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "帳號 : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "密碼 : ";
            // 
            // txtBox帳號
            // 
            this.txtBox帳號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox帳號.Location = new System.Drawing.Point(162, 152);
            this.txtBox帳號.Name = "txtBox帳號";
            this.txtBox帳號.Size = new System.Drawing.Size(206, 33);
            this.txtBox帳號.TabIndex = 16;
            this.txtBox帳號.TextChanged += new System.EventHandler(this.txtBox帳號_TextChanged);
            // 
            // txtBox密碼
            // 
            this.txtBox密碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox密碼.Location = new System.Drawing.Point(162, 207);
            this.txtBox密碼.MaxLength = 16;
            this.txtBox密碼.Name = "txtBox密碼";
            this.txtBox密碼.PasswordChar = '*';
            this.txtBox密碼.Size = new System.Drawing.Size(206, 33);
            this.txtBox密碼.TabIndex = 17;
            this.txtBox密碼.TextChanged += new System.EventHandler(this.txtBox密碼_TextChanged);
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.Bisque;
            this.btn登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(388, 207);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(90, 31);
            this.btn登入.TabIndex = 18;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn註冊會員
            // 
            this.btn註冊會員.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn註冊會員.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn註冊會員.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn註冊會員.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn註冊會員.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊會員.ForeColor = System.Drawing.Color.Blue;
            this.btn註冊會員.Location = new System.Drawing.Point(401, 244);
            this.btn註冊會員.Name = "btn註冊會員";
            this.btn註冊會員.Size = new System.Drawing.Size(68, 21);
            this.btn註冊會員.TabIndex = 25;
            this.btn註冊會員.Text = "註冊會員";
            this.btn註冊會員.UseVisualStyleBackColor = true;
            this.btn註冊會員.Click += new System.EventHandler(this.btn註冊會員_Click);
            // 
            // btn免註冊訂餐
            // 
            this.btn免註冊訂餐.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn免註冊訂餐.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn免註冊訂餐.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn免註冊訂餐.Location = new System.Drawing.Point(87, 246);
            this.btn免註冊訂餐.Name = "btn免註冊訂餐";
            this.btn免註冊訂餐.Size = new System.Drawing.Size(286, 46);
            this.btn免註冊訂餐.TabIndex = 26;
            this.btn免註冊訂餐.Text = "免註冊訂餐";
            this.btn免註冊訂餐.UseVisualStyleBackColor = false;
            this.btn免註冊訂餐.Click += new System.EventHandler(this.btn免註冊訂餐_Click);
            // 
            // chB管理登入
            // 
            this.chB管理登入.AutoSize = true;
            this.chB管理登入.ForeColor = System.Drawing.Color.Blue;
            this.chB管理登入.Location = new System.Drawing.Point(401, 271);
            this.chB管理登入.Name = "chB管理登入";
            this.chB管理登入.Size = new System.Drawing.Size(72, 16);
            this.chB管理登入.TabIndex = 27;
            this.chB管理登入.Text = "管理登入";
            this.chB管理登入.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(530, 386);
            this.Controls.Add(this.chB管理登入);
            this.Controls.Add(this.btn免註冊訂餐);
            this.Controls.Add(this.btn註冊會員);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txtBox密碼);
            this.Controls.Add(this.txtBox帳號);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox帳號;
        private System.Windows.Forms.TextBox txtBox密碼;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn註冊會員;
        private System.Windows.Forms.Button btn免註冊訂餐;
        private System.Windows.Forms.CheckBox chB管理登入;
    }
}