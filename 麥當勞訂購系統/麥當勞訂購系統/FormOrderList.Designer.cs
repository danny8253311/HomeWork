namespace 麥當勞訂購系統
{
    partial class FormOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderList));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox品項列表 = new System.Windows.Forms.ListBox();
            this.lbl顯示多筆項目 = new System.Windows.Forms.Label();
            this.lbl總金額 = new System.Windows.Forms.Label();
            this.btn送出訂單 = new System.Windows.Forms.Button();
            this.btn清除所有商品 = new System.Windows.Forms.Button();
            this.btn取消訂單 = new System.Windows.Forms.Button();
            this.btn顧客資訊 = new System.Windows.Forms.Button();
            this.btn返回菜單 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "cDonald\'s";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 44);
            this.label2.TabIndex = 20;
            this.label2.Text = "您的訂單";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox品項列表
            // 
            this.listBox品項列表.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox品項列表.FormattingEnabled = true;
            this.listBox品項列表.ItemHeight = 20;
            this.listBox品項列表.Location = new System.Drawing.Point(20, 196);
            this.listBox品項列表.Name = "listBox品項列表";
            this.listBox品項列表.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox品項列表.Size = new System.Drawing.Size(487, 324);
            this.listBox品項列表.TabIndex = 21;
            this.listBox品項列表.SelectedIndexChanged += new System.EventHandler(this.listBox品項列表_SelectedIndexChanged);
            // 
            // lbl顯示多筆項目
            // 
            this.lbl顯示多筆項目.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl顯示多筆項目.BackColor = System.Drawing.Color.DarkGreen;
            this.lbl顯示多筆項目.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl顯示多筆項目.ForeColor = System.Drawing.Color.White;
            this.lbl顯示多筆項目.Location = new System.Drawing.Point(19, 555);
            this.lbl顯示多筆項目.Name = "lbl顯示多筆項目";
            this.lbl顯示多筆項目.Size = new System.Drawing.Size(169, 44);
            this.lbl顯示多筆項目.TabIndex = 22;
            this.lbl顯示多筆項目.Text = "共 0 項";
            this.lbl顯示多筆項目.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl總金額
            // 
            this.lbl總金額.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl總金額.BackColor = System.Drawing.Color.DarkGreen;
            this.lbl總金額.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總金額.ForeColor = System.Drawing.Color.White;
            this.lbl總金額.Location = new System.Drawing.Point(222, 555);
            this.lbl總金額.Name = "lbl總金額";
            this.lbl總金額.Size = new System.Drawing.Size(284, 44);
            this.lbl總金額.TabIndex = 23;
            this.lbl總金額.Text = "總金額 : 0000元";
            this.lbl總金額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn送出訂單
            // 
            this.btn送出訂單.AutoSize = true;
            this.btn送出訂單.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn送出訂單.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn送出訂單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出訂單.Location = new System.Drawing.Point(352, 651);
            this.btn送出訂單.Name = "btn送出訂單";
            this.btn送出訂單.Size = new System.Drawing.Size(155, 55);
            this.btn送出訂單.TabIndex = 24;
            this.btn送出訂單.Text = "送出訂單";
            this.btn送出訂單.UseVisualStyleBackColor = false;
            this.btn送出訂單.Click += new System.EventHandler(this.btn送出訂單_Click);
            // 
            // btn清除所有商品
            // 
            this.btn清除所有商品.AutoSize = true;
            this.btn清除所有商品.BackColor = System.Drawing.Color.PaleGreen;
            this.btn清除所有商品.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn清除所有商品.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有商品.Location = new System.Drawing.Point(186, 651);
            this.btn清除所有商品.Name = "btn清除所有商品";
            this.btn清除所有商品.Size = new System.Drawing.Size(155, 55);
            this.btn清除所有商品.TabIndex = 25;
            this.btn清除所有商品.Text = "清除所有商品";
            this.btn清除所有商品.UseVisualStyleBackColor = false;
            this.btn清除所有商品.Click += new System.EventHandler(this.btn清除所有商品_Click);
            // 
            // btn取消訂單
            // 
            this.btn取消訂單.AutoSize = true;
            this.btn取消訂單.BackColor = System.Drawing.Color.Red;
            this.btn取消訂單.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn取消訂單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消訂單.ForeColor = System.Drawing.Color.White;
            this.btn取消訂單.Location = new System.Drawing.Point(20, 651);
            this.btn取消訂單.Name = "btn取消訂單";
            this.btn取消訂單.Size = new System.Drawing.Size(155, 55);
            this.btn取消訂單.TabIndex = 27;
            this.btn取消訂單.Text = "取消訂單";
            this.btn取消訂單.UseVisualStyleBackColor = false;
            this.btn取消訂單.Click += new System.EventHandler(this.btn取消訂單_Click);
            // 
            // btn顧客資訊
            // 
            this.btn顧客資訊.AutoSize = true;
            this.btn顧客資訊.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn顧客資訊.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn顧客資訊.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顧客資訊.Location = new System.Drawing.Point(351, 139);
            this.btn顧客資訊.Name = "btn顧客資訊";
            this.btn顧客資訊.Size = new System.Drawing.Size(155, 44);
            this.btn顧客資訊.TabIndex = 28;
            this.btn顧客資訊.Text = "顧客資訊";
            this.btn顧客資訊.UseVisualStyleBackColor = false;
            this.btn顧客資訊.Click += new System.EventHandler(this.btn顧客資訊_Click);
            // 
            // btn返回菜單
            // 
            this.btn返回菜單.AutoSize = true;
            this.btn返回菜單.BackColor = System.Drawing.Color.PaleGreen;
            this.btn返回菜單.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn返回菜單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn返回菜單.Location = new System.Drawing.Point(12, 22);
            this.btn返回菜單.Name = "btn返回菜單";
            this.btn返回菜單.Size = new System.Drawing.Size(106, 36);
            this.btn返回菜單.TabIndex = 29;
            this.btn返回菜單.Text = "返回菜單";
            this.btn返回菜單.UseVisualStyleBackColor = false;
            this.btn返回菜單.Click += new System.EventHandler(this.btn返回菜單_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(530, 738);
            this.Controls.Add(this.btn返回菜單);
            this.Controls.Add(this.btn顧客資訊);
            this.Controls.Add(this.btn取消訂單);
            this.Controls.Add(this.btn清除所有商品);
            this.Controls.Add(this.btn送出訂單);
            this.Controls.Add(this.lbl總金額);
            this.Controls.Add(this.lbl顯示多筆項目);
            this.Controls.Add(this.listBox品項列表);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrderList";
            this.Text = "訂單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrderList_FormClosing);
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox listBox品項列表;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl顯示多筆項目;
        public System.Windows.Forms.Label lbl總金額;
        public System.Windows.Forms.Button btn送出訂單;
        public System.Windows.Forms.Button btn清除所有商品;
        public System.Windows.Forms.Button btn取消訂單;
        public System.Windows.Forms.Button btn顧客資訊;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn返回菜單;
    }
}