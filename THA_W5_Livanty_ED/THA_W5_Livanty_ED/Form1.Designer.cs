namespace THA_W5_Livanty_ED
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
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_details = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.btn_removecategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.txt_namaproduct = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_namacategory = new System.Windows.Forms.TextBox();
            this.btn_editproduct = new System.Windows.Forms.Button();
            this.btn_removeproduct = new System.Windows.Forms.Button();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.Location = new System.Drawing.Point(41, 39);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(103, 29);
            this.lbl_product.TabIndex = 0;
            this.lbl_product.Text = "Product";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(654, 39);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(118, 29);
            this.lbl_category.TabIndex = 1;
            this.lbl_category.Text = "Category";
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_details.Location = new System.Drawing.Point(47, 362);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(94, 29);
            this.lbl_details.TabIndex = 2;
            this.lbl_details.Text = "Details";
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(167, 68);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 28);
            this.btn_all.TabIndex = 3;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(262, 68);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 28);
            this.btn_filter.TabIndex = 4;
            this.btn_filter.Text = "Filter: ";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // cmb_filter
            // 
            this.cmb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter.Enabled = false;
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Location = new System.Drawing.Point(352, 63);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(121, 28);
            this.cmb_filter.TabIndex = 5;
            this.cmb_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_filter_SelectedIndexChanged);
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(46, 102);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 62;
            this.dgv_product.RowTemplate.Height = 28;
            this.dgv_product.Size = new System.Drawing.Size(581, 257);
            this.dgv_product.TabIndex = 6;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            this.dgv_product.SelectionChanged += new System.EventHandler(this.dgv_product_SelectionChanged);
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(659, 81);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 62;
            this.dgv_category.RowTemplate.Height = 28;
            this.dgv_category.Size = new System.Drawing.Size(364, 213);
            this.dgv_category.TabIndex = 7;
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
            this.dgv_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellContentClick);
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.Location = new System.Drawing.Point(664, 349);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(96, 55);
            this.btn_addcategory.TabIndex = 8;
            this.btn_addcategory.Text = "Add Category";
            this.btn_addcategory.UseVisualStyleBackColor = true;
            this.btn_addcategory.Click += new System.EventHandler(this.btn_addcategory_Click);
            // 
            // btn_removecategory
            // 
            this.btn_removecategory.Location = new System.Drawing.Point(779, 349);
            this.btn_removecategory.Name = "btn_removecategory";
            this.btn_removecategory.Size = new System.Drawing.Size(98, 55);
            this.btn_removecategory.TabIndex = 9;
            this.btn_removecategory.Text = "Remove Category";
            this.btn_removecategory.UseVisualStyleBackColor = true;
            this.btn_removecategory.Click += new System.EventHandler(this.btn_removecategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Harga: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock: ";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(660, 315);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(59, 20);
            this.lbl_nama.TabIndex = 14;
            this.lbl_nama.Text = "Nama: ";
            // 
            // txt_namaproduct
            // 
            this.txt_namaproduct.Location = new System.Drawing.Point(134, 402);
            this.txt_namaproduct.Name = "txt_namaproduct";
            this.txt_namaproduct.Size = new System.Drawing.Size(249, 26);
            this.txt_namaproduct.TabIndex = 15;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(134, 467);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(124, 26);
            this.txt_harga.TabIndex = 17;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(134, 499);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(124, 26);
            this.txt_stock.TabIndex = 18;
            // 
            // txt_namacategory
            // 
            this.txt_namacategory.Location = new System.Drawing.Point(717, 312);
            this.txt_namacategory.Name = "txt_namacategory";
            this.txt_namacategory.Size = new System.Drawing.Size(160, 26);
            this.txt_namacategory.TabIndex = 19;
            // 
            // btn_editproduct
            // 
            this.btn_editproduct.Location = new System.Drawing.Point(345, 452);
            this.btn_editproduct.Name = "btn_editproduct";
            this.btn_editproduct.Size = new System.Drawing.Size(84, 55);
            this.btn_editproduct.TabIndex = 20;
            this.btn_editproduct.Text = "Edit Product";
            this.btn_editproduct.UseVisualStyleBackColor = true;
            this.btn_editproduct.Click += new System.EventHandler(this.btn_editproduct_Click);
            // 
            // btn_removeproduct
            // 
            this.btn_removeproduct.Location = new System.Drawing.Point(424, 452);
            this.btn_removeproduct.Name = "btn_removeproduct";
            this.btn_removeproduct.Size = new System.Drawing.Size(88, 55);
            this.btn_removeproduct.TabIndex = 21;
            this.btn_removeproduct.Text = "Remove Product";
            this.btn_removeproduct.UseVisualStyleBackColor = true;
            this.btn_removeproduct.Click += new System.EventHandler(this.btn_removeproduct_Click);
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(264, 452);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(82, 56);
            this.btn_addproduct.TabIndex = 22;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(134, 433);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(124, 28);
            this.cmb_category.TabIndex = 23;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 580);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.btn_removeproduct);
            this.Controls.Add(this.btn_editproduct);
            this.Controls.Add(this.txt_namacategory);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_namaproduct);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_removecategory);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.cmb_filter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.Button btn_removecategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.TextBox txt_namaproduct;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_namacategory;
        private System.Windows.Forms.Button btn_editproduct;
        private System.Windows.Forms.Button btn_removeproduct;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.ComboBox cmb_category;
    }
}

