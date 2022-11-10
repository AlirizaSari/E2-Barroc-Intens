namespace Barroc_Intens.Inkoop
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNameProduct = new System.Windows.Forms.TextBox();
            this.txbDescriptionProduct = new System.Windows.Forms.TextBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.cboxNewProductCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txbBrandProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Toevoegen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Omschijving:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categorie:";
            // 
            // txbNameProduct
            // 
            this.txbNameProduct.Location = new System.Drawing.Point(177, 82);
            this.txbNameProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNameProduct.Name = "txbNameProduct";
            this.txbNameProduct.Size = new System.Drawing.Size(297, 22);
            this.txbNameProduct.TabIndex = 5;
            // 
            // txbDescriptionProduct
            // 
            this.txbDescriptionProduct.Location = new System.Drawing.Point(177, 116);
            this.txbDescriptionProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDescriptionProduct.Name = "txbDescriptionProduct";
            this.txbDescriptionProduct.Size = new System.Drawing.Size(297, 22);
            this.txbDescriptionProduct.TabIndex = 6;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.Location = new System.Drawing.Point(177, 238);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(100, 28);
            this.btnSaveProduct.TabIndex = 9;
            this.btnSaveProduct.Text = "Opslaan";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProduct.Location = new System.Drawing.Point(285, 238);
            this.btnCancelProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(100, 28);
            this.btnCancelProduct.TabIndex = 10;
            this.btnCancelProduct.Text = "Annuleren";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // cboxNewProductCategory
            // 
            this.cboxNewProductCategory.DataSource = this.categoryBindingSource;
            this.cboxNewProductCategory.DisplayMember = "Name";
            this.cboxNewProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNewProductCategory.FormattingEnabled = true;
            this.cboxNewProductCategory.Location = new System.Drawing.Point(177, 181);
            this.cboxNewProductCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxNewProductCategory.Name = "cboxNewProductCategory";
            this.cboxNewProductCategory.Size = new System.Drawing.Size(297, 24);
            this.cboxNewProductCategory.TabIndex = 11;
            this.cboxNewProductCategory.ValueMember = "CategoryId";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Barroc_Intens.Category);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Merk:";
            // 
            // txbBrandProduct
            // 
            this.txbBrandProduct.Location = new System.Drawing.Point(177, 149);
            this.txbBrandProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbBrandProduct.Name = "txbBrandProduct";
            this.txbBrandProduct.Size = new System.Drawing.Size(297, 22);
            this.txbBrandProduct.TabIndex = 13;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 289);
            this.Controls.Add(this.txbBrandProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxNewProductCategory);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.txbDescriptionProduct);
            this.Controls.Add(this.txbNameProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProductForm";
            this.Text = "Product toevoegen";
            this.Load += new System.EventHandler(this.AddProductFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNameProduct;
        private System.Windows.Forms.TextBox txbDescriptionProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.ComboBox cboxNewProductCategory;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBrandProduct;
    }
}