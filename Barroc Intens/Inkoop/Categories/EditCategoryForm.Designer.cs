namespace Barroc_Intens.Inkoop.Categories
{
    partial class EditCategoryForm
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
            this.cbEmployeeOnly = new System.Windows.Forms.CheckBox();
            this.btnCancelCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.txbNameCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEmployeeOnly
            // 
            this.cbEmployeeOnly.AutoSize = true;
            this.cbEmployeeOnly.Location = new System.Drawing.Point(170, 91);
            this.cbEmployeeOnly.Margin = new System.Windows.Forms.Padding(2);
            this.cbEmployeeOnly.Name = "cbEmployeeOnly";
            this.cbEmployeeOnly.Size = new System.Drawing.Size(15, 14);
            this.cbEmployeeOnly.TabIndex = 7;
            this.cbEmployeeOnly.UseVisualStyleBackColor = true;
            // 
            // btnCancelCategory
            // 
            this.btnCancelCategory.Location = new System.Drawing.Point(292, 139);
            this.btnCancelCategory.Name = "btnCancelCategory";
            this.btnCancelCategory.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCategory.TabIndex = 11;
            this.btnCancelCategory.Text = "Annuleren";
            this.btnCancelCategory.UseVisualStyleBackColor = true;
            this.btnCancelCategory.Click += new System.EventHandler(this.btnCancelCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(211, 139);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(75, 23);
            this.btnEditCategory.TabIndex = 10;
            this.btnEditCategory.Text = "Opslaan";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.Location = new System.Drawing.Point(170, 59);
            this.txbNameCategory.Name = "txbNameCategory";
            this.txbNameCategory.Size = new System.Drawing.Size(233, 20);
            this.txbNameCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Is alleen voor werknemer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categorie Bewerken";
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 185);
            this.Controls.Add(this.cbEmployeeOnly);
            this.Controls.Add(this.btnCancelCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.txbNameCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCategoryForm";
            this.Text = "Categorie Bewerken";
            this.Load += new System.EventHandler(this.EditCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbEmployeeOnly;
        private System.Windows.Forms.Button btnCancelCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.TextBox txbNameCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}