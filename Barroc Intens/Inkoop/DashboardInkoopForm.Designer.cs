namespace Barroc_Intens
{
    partial class DashboardInkoopForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblExtraInfo = new System.Windows.Forms.Label();
            this.txbExtraInfo = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblInkoop = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnInkoop = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEmployeeOnlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlLeft.Controls.Add(this.lblExtraInfo);
            this.pnlLeft.Controls.Add(this.txbExtraInfo);
            this.pnlLeft.Controls.Add(this.btnLogout);
            this.pnlLeft.Controls.Add(this.lblDepartment);
            this.pnlLeft.Controls.Add(this.lblAccountName);
            this.pnlLeft.Controls.Add(this.pboxLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(222, 600);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblExtraInfo
            // 
            this.lblExtraInfo.AutoSize = true;
            this.lblExtraInfo.Location = new System.Drawing.Point(20, 322);
            this.lblExtraInfo.Name = "lblExtraInfo";
            this.lblExtraInfo.Size = new System.Drawing.Size(91, 15);
            this.lblExtraInfo.TabIndex = 6;
            this.lblExtraInfo.Text = "Extra Informatie";
            // 
            // txbExtraInfo
            // 
            this.txbExtraInfo.Location = new System.Drawing.Point(24, 345);
            this.txbExtraInfo.Multiline = true;
            this.txbExtraInfo.Name = "txbExtraInfo";
            this.txbExtraInfo.Size = new System.Drawing.Size(162, 160);
            this.txbExtraInfo.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(24, 525);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(162, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(53, 249);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(52, 15);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Afdeling";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(53, 220);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(87, 15);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Account Naam";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(61, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(100, 100);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 1;
            this.pboxLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTop.Controls.Add(this.lblInkoop);
            this.pnlTop.Controls.Add(this.btnBackToMain);
            this.pnlTop.Controls.Add(this.btnStock);
            this.pnlTop.Controls.Add(this.btnInkoop);
            this.pnlTop.Location = new System.Drawing.Point(222, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(692, 157);
            this.pnlTop.TabIndex = 1;
            // 
            // lblInkoop
            // 
            this.lblInkoop.AutoSize = true;
            this.lblInkoop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInkoop.Location = new System.Drawing.Point(293, 30);
            this.lblInkoop.Name = "lblInkoop";
            this.lblInkoop.Size = new System.Drawing.Size(95, 32);
            this.lblInkoop.TabIndex = 3;
            this.lblInkoop.Text = "Inkoop";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(52, 117);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(172, 37);
            this.btnBackToMain.TabIndex = 2;
            this.btnBackToMain.Text = "Home";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(492, 117);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(172, 37);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Voorraad";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnInkoop
            // 
            this.btnInkoop.Location = new System.Drawing.Point(272, 117);
            this.btnInkoop.Name = "btnInkoop";
            this.btnInkoop.Size = new System.Drawing.Size(172, 37);
            this.btnInkoop.TabIndex = 0;
            this.btnInkoop.Text = "Inkopen";
            this.btnInkoop.UseVisualStyleBackColor = true;
            this.btnInkoop.Click += new System.EventHandler(this.btnInkoop_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(228, 366);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(172, 37);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Product Toevoegen";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(406, 366);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(172, 37);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "Product Aanpassen";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(584, 366);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(172, 37);
            this.btnRemoveProduct.TabIndex = 5;
            this.btnRemoveProduct.Text = "Product Verwijderen";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(537, 468);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(172, 37);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Categorie Toevoegen";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(537, 511);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(172, 37);
            this.btnEditCategory.TabIndex = 8;
            this.btnEditCategory.Text = "Categorie Aanpassen";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(537, 554);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(172, 37);
            this.btnRemoveCategory.TabIndex = 9;
            this.btnRemoveCategory.Text = "Categorie Verwijderen";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Brand,
            this.categoryDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(229, 164);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.Size = new System.Drawing.Size(673, 196);
            this.productsDataGridView.TabIndex = 10;
            this.productsDataGridView.SelectionChanged += new System.EventHandler(this.productsDataGridView_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Barroc_Intens.Product);
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.AutoGenerateColumns = false;
            this.categoriesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.isEmployeeOnlyDataGridViewTextBoxColumn});
            this.categoriesDataGridView.DataSource = this.categoryBindingSource;
            this.categoriesDataGridView.Location = new System.Drawing.Point(229, 410);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.RowHeadersWidth = 51;
            this.categoriesDataGridView.Size = new System.Drawing.Size(302, 178);
            this.categoriesDataGridView.TabIndex = 11;
            this.categoriesDataGridView.SelectionChanged += new System.EventHandler(this.categoriesDataGridView_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // isEmployeeOnlyDataGridViewTextBoxColumn
            // 
            this.isEmployeeOnlyDataGridViewTextBoxColumn.DataPropertyName = "IsEmployeeOnly";
            this.isEmployeeOnlyDataGridViewTextBoxColumn.HeaderText = "IsEmployeeOnly";
            this.isEmployeeOnlyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isEmployeeOnlyDataGridViewTextBoxColumn.Name = "isEmployeeOnlyDataGridViewTextBoxColumn";
            this.isEmployeeOnlyDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Barroc_Intens.Category);
            // 
            // DashboardInkoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.categoriesDataGridView);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardInkoopForm";
            this.Text = "Dashboard voor inkoop";
            this.Load += new System.EventHandler(this.DashboardInkoopForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblExtraInfo;
        private System.Windows.Forms.TextBox txbExtraInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblInkoop;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnInkoop;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isEmployeeOnlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}