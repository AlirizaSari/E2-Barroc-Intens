namespace Barroc_Intens.Inkoop
{
    partial class ProductenForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackToInkoopDashboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.ColumnHeadersVisible = false;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(123, 159);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.ShowCellErrors = false;
            this.productDataGridView.ShowCellToolTips = false;
            this.productDataGridView.ShowEditingIcon = false;
            this.productDataGridView.ShowRowErrors = false;
            this.productDataGridView.Size = new System.Drawing.Size(422, 313);
            this.productDataGridView.TabIndex = 1;
            this.productDataGridView.SelectionChanged += new System.EventHandler(this.productDataGridView_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Barroc_Intens.Product);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producten:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(123, 111);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.ValueMember = "CategoryId";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Barroc_Intens.Category);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categorie:";
            // 
            // btnBackToInkoopDashboard
            // 
            this.btnBackToInkoopDashboard.Location = new System.Drawing.Point(655, 28);
            this.btnBackToInkoopDashboard.Name = "btnBackToInkoopDashboard";
            this.btnBackToInkoopDashboard.Size = new System.Drawing.Size(182, 28);
            this.btnBackToInkoopDashboard.TabIndex = 5;
            this.btnBackToInkoopDashboard.Text = "Terug naar inkoop dashboard";
            this.btnBackToInkoopDashboard.UseVisualStyleBackColor = true;
            this.btnBackToInkoopDashboard.Click += new System.EventHandler(this.btnBackToInkoopDashboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product Informatie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Naam:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Omschrijving:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Merk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Categorie:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(652, 168);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(81, 15);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "ProductNaam";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(652, 192);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(120, 15);
            this.lblProductDescription.TabIndex = 12;
            this.lblProductDescription.Text = "ProductOmschrijving";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBrand.Location = new System.Drawing.Point(652, 217);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(76, 15);
            this.lblProductBrand.TabIndex = 13;
            this.lblProductBrand.Text = "ProductMerk";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(652, 243);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(100, 15);
            this.lblProductCategory.TabIndex = 14;
            this.lblProductCategory.Text = "ProductCategorie";
            // 
            // ProductenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 496);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.lblProductBrand);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBackToInkoopDashboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductenForm";
            this.Text = "ProductenForm";
            this.Load += new System.EventHandler(this.ProductenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackToInkoopDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductCategory;
    }
}