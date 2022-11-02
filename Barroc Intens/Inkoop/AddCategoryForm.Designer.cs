namespace Barroc_Intens.Inkoop
{
    partial class AddCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNameCategory = new System.Windows.Forms.TextBox();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnCancelCategory = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.cbEmployeeOnly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie Toevoegen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 89);
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
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is alleen voor werknemer:";
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.Location = new System.Drawing.Point(227, 85);
            this.txbNameCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txbNameCategory.Name = "txbNameCategory";
            this.txbNameCategory.Size = new System.Drawing.Size(309, 22);
            this.txbNameCategory.TabIndex = 0;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(281, 183);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(100, 28);
            this.btnSaveCategory.TabIndex = 3;
            this.btnSaveCategory.Text = "Opslaan";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // btnCancelCategory
            // 
            this.btnCancelCategory.Location = new System.Drawing.Point(389, 183);
            this.btnCancelCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelCategory.Name = "btnCancelCategory";
            this.btnCancelCategory.Size = new System.Drawing.Size(100, 28);
            this.btnCancelCategory.TabIndex = 4;
            this.btnCancelCategory.Text = "Annuleren";
            this.btnCancelCategory.UseVisualStyleBackColor = true;
            this.btnCancelCategory.Click += new System.EventHandler(this.btnCancelCategory_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(224, 217);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 7;
            // 
            // cbEmployeeOnly
            // 
            this.cbEmployeeOnly.AutoSize = true;
            this.cbEmployeeOnly.Location = new System.Drawing.Point(227, 124);
            this.cbEmployeeOnly.Name = "cbEmployeeOnly";
            this.cbEmployeeOnly.Size = new System.Drawing.Size(18, 17);
            this.cbEmployeeOnly.TabIndex = 1;
            this.cbEmployeeOnly.UseVisualStyleBackColor = true;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 242);
            this.Controls.Add(this.cbEmployeeOnly);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.txbNameCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCategoryForm";
            this.Text = "Categorie toevoegen";
            this.Load += new System.EventHandler(this.AddCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNameCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnCancelCategory;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox cbEmployeeOnly;
    }
}