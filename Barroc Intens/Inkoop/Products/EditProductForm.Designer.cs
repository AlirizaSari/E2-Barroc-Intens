namespace Barroc_Intens.Inkoop.Products
{
    partial class EditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            this.txbBrandProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxProductCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.txbDescriptionProduct = new System.Windows.Forms.TextBox();
            this.txbNameProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBrandProduct
            // 
            this.txbBrandProduct.Location = new System.Drawing.Point(133, 111);
            this.txbBrandProduct.Name = "txbBrandProduct";
            this.txbBrandProduct.Size = new System.Drawing.Size(224, 20);
            this.txbBrandProduct.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Merk:";
            // 
            // cboxProductCategory
            // 
            this.cboxProductCategory.DataSource = this.categoryBindingSource;
            this.cboxProductCategory.DisplayMember = "Name";
            this.cboxProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProductCategory.FormattingEnabled = true;
            this.cboxProductCategory.Location = new System.Drawing.Point(133, 137);
            this.cboxProductCategory.Name = "cboxProductCategory";
            this.cboxProductCategory.Size = new System.Drawing.Size(224, 21);
            this.cboxProductCategory.TabIndex = 22;
            this.cboxProductCategory.ValueMember = "CategoryId";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Barroc_Intens.Category);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.categoryBindingSource;
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProduct.Location = new System.Drawing.Point(214, 183);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProduct.TabIndex = 21;
            this.btnCancelProduct.Text = "Annuleren";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Location = new System.Drawing.Point(133, 183);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 23);
            this.btnEditProduct.TabIndex = 20;
            this.btnEditProduct.Text = "Opslaan";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // txbDescriptionProduct
            // 
            this.txbDescriptionProduct.Location = new System.Drawing.Point(133, 84);
            this.txbDescriptionProduct.Name = "txbDescriptionProduct";
            this.txbDescriptionProduct.Size = new System.Drawing.Size(224, 20);
            this.txbDescriptionProduct.TabIndex = 19;
            // 
            // txbNameProduct
            // 
            this.txbNameProduct.Location = new System.Drawing.Point(133, 57);
            this.txbNameProduct.Name = "txbNameProduct";
            this.txbNameProduct.Size = new System.Drawing.Size(224, 20);
            this.txbNameProduct.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Categorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Omschijving:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Naam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product Bewerken";
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 222);
            this.Controls.Add(this.txbBrandProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxProductCategory);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.txbDescriptionProduct);
            this.Controls.Add(this.txbNameProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProductForm";
            this.Text = "Product Bewerken";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBrandProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxProductCategory;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.TextBox txbDescriptionProduct;
        private System.Windows.Forms.TextBox txbNameProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}