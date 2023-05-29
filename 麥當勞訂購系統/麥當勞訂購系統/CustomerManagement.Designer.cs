namespace 麥當勞訂購系統
{
    partial class CustomerManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcDonaldsOrderSystemDataSet = new 麥當勞訂購系統.McDonaldsOrderSystemDataSet();
            this.lbl標題 = new System.Windows.Forms.Label();
            this.customersTableAdapter = new 麥當勞訂購系統.McDonaldsOrderSystemDataSetTableAdapters.CustomersTableAdapter();
            this.lbl任意內容1 = new System.Windows.Forms.Label();
            this.lbl任意內容3 = new System.Windows.Forms.Label();
            this.lbl任意內容4 = new System.Windows.Forms.Label();
            this.lbl任意內容5 = new System.Windows.Forms.Label();
            this.txt任意內容1 = new System.Windows.Forms.TextBox();
            this.txt任意內容2 = new System.Windows.Forms.TextBox();
            this.txt任意內容3 = new System.Windows.Forms.TextBox();
            this.txt任意內容4 = new System.Windows.Forms.TextBox();
            this.txt任意內容5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn返回菜單 = new System.Windows.Forms.Button();
            this.lbl任意內容2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.dataGridView讀取資料庫 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.cbB商品總類 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcDonaldsOrderSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView讀取資料庫)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "cDonald\'s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.mcDonaldsOrderSystemDataSet;
            // 
            // mcDonaldsOrderSystemDataSet
            // 
            this.mcDonaldsOrderSystemDataSet.DataSetName = "McDonaldsOrderSystemDataSet";
            this.mcDonaldsOrderSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl標題
            // 
            this.lbl標題.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl標題.ForeColor = System.Drawing.Color.White;
            this.lbl標題.Location = new System.Drawing.Point(29, 78);
            this.lbl標題.Name = "lbl標題";
            this.lbl標題.Size = new System.Drawing.Size(360, 48);
            this.lbl標題.TabIndex = 7;
            this.lbl標題.Text = "會員管理";
            this.lbl標題.Click += new System.EventHandler(this.lbl標題_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // lbl任意內容1
            // 
            this.lbl任意內容1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl任意內容1.ForeColor = System.Drawing.Color.White;
            this.lbl任意內容1.Location = new System.Drawing.Point(904, 129);
            this.lbl任意內容1.Name = "lbl任意內容1";
            this.lbl任意內容1.Size = new System.Drawing.Size(134, 37);
            this.lbl任意內容1.TabIndex = 8;
            this.lbl任意內容1.Text = "顧客姓名";
            // 
            // lbl任意內容3
            // 
            this.lbl任意內容3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl任意內容3.ForeColor = System.Drawing.Color.White;
            this.lbl任意內容3.Location = new System.Drawing.Point(904, 365);
            this.lbl任意內容3.Name = "lbl任意內容3";
            this.lbl任意內容3.Size = new System.Drawing.Size(134, 37);
            this.lbl任意內容3.TabIndex = 10;
            this.lbl任意內容3.Text = "電話號碼";
            // 
            // lbl任意內容4
            // 
            this.lbl任意內容4.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl任意內容4.ForeColor = System.Drawing.Color.White;
            this.lbl任意內容4.Location = new System.Drawing.Point(927, 483);
            this.lbl任意內容4.Name = "lbl任意內容4";
            this.lbl任意內容4.Size = new System.Drawing.Size(131, 37);
            this.lbl任意內容4.TabIndex = 11;
            this.lbl任意內容4.Text = "Email";
            // 
            // lbl任意內容5
            // 
            this.lbl任意內容5.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl任意內容5.ForeColor = System.Drawing.Color.White;
            this.lbl任意內容5.Location = new System.Drawing.Point(936, 597);
            this.lbl任意內容5.Name = "lbl任意內容5";
            this.lbl任意內容5.Size = new System.Drawing.Size(279, 37);
            this.lbl任意內容5.TabIndex = 12;
            this.lbl任意內容5.Text = "密碼";
            // 
            // txt任意內容1
            // 
            this.txt任意內容1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt任意內容1.Location = new System.Drawing.Point(886, 181);
            this.txt任意內容1.Name = "txt任意內容1";
            this.txt任意內容1.Size = new System.Drawing.Size(172, 29);
            this.txt任意內容1.TabIndex = 13;
            // 
            // txt任意內容2
            // 
            this.txt任意內容2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt任意內容2.Location = new System.Drawing.Point(886, 293);
            this.txt任意內容2.Name = "txt任意內容2";
            this.txt任意內容2.Size = new System.Drawing.Size(172, 35);
            this.txt任意內容2.TabIndex = 14;
            // 
            // txt任意內容3
            // 
            this.txt任意內容3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt任意內容3.Location = new System.Drawing.Point(886, 418);
            this.txt任意內容3.Name = "txt任意內容3";
            this.txt任意內容3.Size = new System.Drawing.Size(172, 35);
            this.txt任意內容3.TabIndex = 15;
            // 
            // txt任意內容4
            // 
            this.txt任意內容4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt任意內容4.Location = new System.Drawing.Point(886, 546);
            this.txt任意內容4.Name = "txt任意內容4";
            this.txt任意內容4.Size = new System.Drawing.Size(172, 29);
            this.txt任意內容4.TabIndex = 16;
            // 
            // txt任意內容5
            // 
            this.txt任意內容5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt任意內容5.Location = new System.Drawing.Point(886, 650);
            this.txt任意內容5.Name = "txt任意內容5";
            this.txt任意內容5.Size = new System.Drawing.Size(172, 29);
            this.txt任意內容5.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(893, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "儲存變更";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn儲存變更_Click);
            // 
            // btn返回菜單
            // 
            this.btn返回菜單.AutoSize = true;
            this.btn返回菜單.BackColor = System.Drawing.Color.PaleGreen;
            this.btn返回菜單.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn返回菜單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn返回菜單.Location = new System.Drawing.Point(12, 22);
            this.btn返回菜單.Name = "btn返回菜單";
            this.btn返回菜單.Size = new System.Drawing.Size(127, 46);
            this.btn返回菜單.TabIndex = 30;
            this.btn返回菜單.Text = "返回主選單";
            this.btn返回菜單.UseVisualStyleBackColor = false;
            this.btn返回菜單.Click += new System.EventHandler(this.btn返回菜單_Click);
            // 
            // lbl任意內容2
            // 
            this.lbl任意內容2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl任意內容2.ForeColor = System.Drawing.Color.White;
            this.lbl任意內容2.Location = new System.Drawing.Point(927, 237);
            this.lbl任意內容2.Name = "lbl任意內容2";
            this.lbl任意內容2.Size = new System.Drawing.Size(179, 37);
            this.lbl任意內容2.TabIndex = 31;
            this.lbl任意內容2.Text = "地址";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(974, 704);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 32;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.AutoSize = true;
            this.btn刪除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn刪除.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn刪除.Location = new System.Drawing.Point(850, 704);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(108, 47);
            this.btn刪除.TabIndex = 33;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = false;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // dataGridView讀取資料庫
            // 
            this.dataGridView讀取資料庫.AllowUserToAddRows = false;
            this.dataGridView讀取資料庫.AllowUserToDeleteRows = false;
            this.dataGridView讀取資料庫.AllowUserToResizeColumns = false;
            this.dataGridView讀取資料庫.AllowUserToResizeRows = false;
            this.dataGridView讀取資料庫.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView讀取資料庫.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView讀取資料庫.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView讀取資料庫.GridColor = System.Drawing.Color.Black;
            this.dataGridView讀取資料庫.Location = new System.Drawing.Point(37, 129);
            this.dataGridView讀取資料庫.Name = "dataGridView讀取資料庫";
            this.dataGridView讀取資料庫.ReadOnly = true;
            this.dataGridView讀取資料庫.RowTemplate.Height = 50;
            this.dataGridView讀取資料庫.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView讀取資料庫.Size = new System.Drawing.Size(795, 541);
            this.dataGridView讀取資料庫.TabIndex = 34;
            this.dataGridView讀取資料庫.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView讀取資料庫_CellClick);
            this.dataGridView讀取資料庫.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView讀取資料庫_CellContentClick);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(194, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 34);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "0000";
            // 
            // cbB商品總類
            // 
            this.cbB商品總類.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbB商品總類.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbB商品總類.FormattingEnabled = true;
            this.cbB商品總類.Location = new System.Drawing.Point(292, 89);
            this.cbB商品總類.Name = "cbB商品總類";
            this.cbB商品總類.Size = new System.Drawing.Size(130, 32);
            this.cbB商品總類.TabIndex = 36;
            this.cbB商品總類.Text = "請選擇分類";
            this.cbB商品總類.SelectedIndexChanged += new System.EventHandler(this.cbB商品總類_SelectedIndexChanged);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1118, 763);
            this.Controls.Add(this.cbB商品總類);
            this.Controls.Add(this.dataGridView讀取資料庫);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl任意內容2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt任意內容5);
            this.Controls.Add(this.txt任意內容4);
            this.Controls.Add(this.txt任意內容3);
            this.Controls.Add(this.txt任意內容2);
            this.Controls.Add(this.txt任意內容1);
            this.Controls.Add(this.lbl任意內容5);
            this.Controls.Add(this.lbl任意內容4);
            this.Controls.Add(this.lbl任意內容3);
            this.Controls.Add(this.lbl任意內容1);
            this.Controls.Add(this.lbl標題);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btn返回菜單);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcDonaldsOrderSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView讀取資料庫)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl標題;
        private McDonaldsOrderSystemDataSet mcDonaldsOrderSystemDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private McDonaldsOrderSystemDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label lbl任意內容3;
        private System.Windows.Forms.Label lbl任意內容4;
        private System.Windows.Forms.Label lbl任意內容5;
        private System.Windows.Forms.TextBox txt任意內容1;
        private System.Windows.Forms.TextBox txt任意內容2;
        private System.Windows.Forms.TextBox txt任意內容3;
        private System.Windows.Forms.TextBox txt任意內容4;
        private System.Windows.Forms.TextBox txt任意內容5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn返回菜單;
        private System.Windows.Forms.Label lbl任意內容2;
        public System.Windows.Forms.Label lbl任意內容1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.DataGridView dataGridView讀取資料庫;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbB商品總類;
    }
}