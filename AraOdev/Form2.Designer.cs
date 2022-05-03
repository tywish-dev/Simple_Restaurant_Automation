namespace AraOdev
{
    partial class Form2
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
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuFoodName = new System.Windows.Forms.TextBox();
            this.menuPrice = new System.Windows.Forms.TextBox();
            this.menuCategory = new System.Windows.Forms.TextBox();
            this.menuInsert = new System.Windows.Forms.Button();
            this.menuList = new System.Windows.Forms.Button();
            this.menuUpdate = new System.Windows.Forms.Button();
            this.menuDelete = new System.Windows.Forms.Button();
            this.customerDelete = new System.Windows.Forms.Button();
            this.customerUpdate = new System.Windows.Forms.Button();
            this.customerList = new System.Windows.Forms.Button();
            this.customerInsert = new System.Windows.Forms.Button();
            this.customerPassword = new System.Windows.Forms.TextBox();
            this.customerUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGridView
            // 
            this.menuGridView.AllowUserToAddRows = false;
            this.menuGridView.AllowUserToDeleteRows = false;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.Location = new System.Drawing.Point(12, 354);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.Size = new System.Drawing.Size(632, 286);
            this.menuGridView.TabIndex = 0;
            this.menuGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.menuGridView_CellMouseClick);
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(679, 354);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(632, 286);
            this.customerGridView.TabIndex = 1;
            this.customerGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerGridView_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(48, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yemek Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(90, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(65, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori :";
            // 
            // menuFoodName
            // 
            this.menuFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuFoodName.Location = new System.Drawing.Point(148, 124);
            this.menuFoodName.Name = "menuFoodName";
            this.menuFoodName.Size = new System.Drawing.Size(144, 26);
            this.menuFoodName.TabIndex = 5;
            // 
            // menuPrice
            // 
            this.menuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuPrice.Location = new System.Drawing.Point(148, 155);
            this.menuPrice.Name = "menuPrice";
            this.menuPrice.Size = new System.Drawing.Size(144, 26);
            this.menuPrice.TabIndex = 6;
            // 
            // menuCategory
            // 
            this.menuCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuCategory.Location = new System.Drawing.Point(148, 188);
            this.menuCategory.Name = "menuCategory";
            this.menuCategory.Size = new System.Drawing.Size(144, 26);
            this.menuCategory.TabIndex = 7;
            // 
            // menuInsert
            // 
            this.menuInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuInsert.Location = new System.Drawing.Point(309, 78);
            this.menuInsert.Name = "menuInsert";
            this.menuInsert.Size = new System.Drawing.Size(90, 87);
            this.menuInsert.TabIndex = 8;
            this.menuInsert.Text = "Ekle";
            this.menuInsert.UseVisualStyleBackColor = true;
            this.menuInsert.Click += new System.EventHandler(this.menuInsert_Click);
            // 
            // menuList
            // 
            this.menuList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuList.Location = new System.Drawing.Point(416, 78);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(90, 87);
            this.menuList.TabIndex = 9;
            this.menuList.Text = "Listele";
            this.menuList.UseVisualStyleBackColor = true;
            this.menuList.Click += new System.EventHandler(this.menuList_Click);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuUpdate.Location = new System.Drawing.Point(309, 171);
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(90, 87);
            this.menuUpdate.TabIndex = 10;
            this.menuUpdate.Text = "Güncelle";
            this.menuUpdate.UseVisualStyleBackColor = true;
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuDelete.Location = new System.Drawing.Point(416, 171);
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(90, 87);
            this.menuDelete.TabIndex = 11;
            this.menuDelete.Text = "Sil";
            this.menuDelete.UseVisualStyleBackColor = true;
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // customerDelete
            // 
            this.customerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerDelete.Location = new System.Drawing.Point(1131, 184);
            this.customerDelete.Name = "customerDelete";
            this.customerDelete.Size = new System.Drawing.Size(90, 87);
            this.customerDelete.TabIndex = 21;
            this.customerDelete.Text = "Sil";
            this.customerDelete.UseVisualStyleBackColor = true;
            this.customerDelete.Click += new System.EventHandler(this.customerDelete_Click);
            // 
            // customerUpdate
            // 
            this.customerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerUpdate.Location = new System.Drawing.Point(1024, 184);
            this.customerUpdate.Name = "customerUpdate";
            this.customerUpdate.Size = new System.Drawing.Size(90, 87);
            this.customerUpdate.TabIndex = 20;
            this.customerUpdate.Text = "Güncelle";
            this.customerUpdate.UseVisualStyleBackColor = true;
            this.customerUpdate.Click += new System.EventHandler(this.customerUpdate_Click);
            // 
            // customerList
            // 
            this.customerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerList.Location = new System.Drawing.Point(1131, 91);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(90, 87);
            this.customerList.TabIndex = 19;
            this.customerList.Text = "Listele";
            this.customerList.UseVisualStyleBackColor = true;
            this.customerList.Click += new System.EventHandler(this.customerList_Click);
            // 
            // customerInsert
            // 
            this.customerInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerInsert.Location = new System.Drawing.Point(1024, 91);
            this.customerInsert.Name = "customerInsert";
            this.customerInsert.Size = new System.Drawing.Size(90, 87);
            this.customerInsert.TabIndex = 18;
            this.customerInsert.Text = "Ekle";
            this.customerInsert.UseVisualStyleBackColor = true;
            this.customerInsert.Click += new System.EventHandler(this.customerInsert_Click);
            // 
            // customerPassword
            // 
            this.customerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerPassword.Location = new System.Drawing.Point(863, 183);
            this.customerPassword.Name = "customerPassword";
            this.customerPassword.Size = new System.Drawing.Size(144, 26);
            this.customerPassword.TabIndex = 16;
            // 
            // customerUsername
            // 
            this.customerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerUsername.Location = new System.Drawing.Point(863, 152);
            this.customerUsername.Name = "customerUsername";
            this.customerUsername.Size = new System.Drawing.Size(144, 26);
            this.customerUsername.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(798, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(747, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(171, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Menü Tablosu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label7.Location = new System.Drawing.Point(880, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 37);
            this.label7.TabIndex = 23;
            this.label7.Text = "Müşteri Tablosu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 652);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerDelete);
            this.Controls.Add(this.customerUpdate);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.customerInsert);
            this.Controls.Add(this.customerPassword);
            this.Controls.Add(this.customerUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuDelete);
            this.Controls.Add(this.menuUpdate);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.menuInsert);
            this.Controls.Add(this.menuCategory);
            this.Controls.Add(this.menuPrice);
            this.Controls.Add(this.menuFoodName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.menuGridView);
            this.Name = "Form2";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox menuFoodName;
        private System.Windows.Forms.TextBox menuPrice;
        private System.Windows.Forms.TextBox menuCategory;
        private System.Windows.Forms.Button menuInsert;
        private System.Windows.Forms.Button menuList;
        private System.Windows.Forms.Button menuUpdate;
        private System.Windows.Forms.Button menuDelete;
        private System.Windows.Forms.Button customerDelete;
        private System.Windows.Forms.Button customerUpdate;
        private System.Windows.Forms.Button customerList;
        private System.Windows.Forms.Button customerInsert;
        private System.Windows.Forms.TextBox customerPassword;
        private System.Windows.Forms.TextBox customerUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}