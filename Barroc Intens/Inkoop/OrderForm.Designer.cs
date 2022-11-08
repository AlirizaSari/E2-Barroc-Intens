namespace Barroc_Intens.Inkoop
{
    partial class OrderForm
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
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductsOrders = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAcceptOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnBackToDashbaord = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(12, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(100, 100);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 2;
            this.pboxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bestellingen";
            // 
            // dgvProductsOrders
            // 
            this.dgvProductsOrders.AllowUserToAddRows = false;
            this.dgvProductsOrders.AllowUserToDeleteRows = false;
            this.dgvProductsOrders.AllowUserToResizeColumns = false;
            this.dgvProductsOrders.AllowUserToResizeRows = false;
            this.dgvProductsOrders.AutoGenerateColumns = false;
            this.dgvProductsOrders.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProductsOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.amountInStockDataGridViewTextBoxColumn,
            this.OrderAmount,
            this.stockStatusDataGridViewTextBoxColumn});
            this.dgvProductsOrders.DataSource = this.productBindingSource;
            this.dgvProductsOrders.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvProductsOrders.Location = new System.Drawing.Point(148, 60);
            this.dgvProductsOrders.Name = "dgvProductsOrders";
            this.dgvProductsOrders.ReadOnly = true;
            this.dgvProductsOrders.RowHeadersVisible = false;
            this.dgvProductsOrders.Size = new System.Drawing.Size(640, 311);
            this.dgvProductsOrders.TabIndex = 4;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Barroc_Intens.Product);
            // 
            // btnAcceptOrder
            // 
            this.btnAcceptOrder.Location = new System.Drawing.Point(148, 388);
            this.btnAcceptOrder.Name = "btnAcceptOrder";
            this.btnAcceptOrder.Size = new System.Drawing.Size(141, 34);
            this.btnAcceptOrder.TabIndex = 5;
            this.btnAcceptOrder.Text = "Accepteren";
            this.btnAcceptOrder.UseVisualStyleBackColor = true;
            this.btnAcceptOrder.Click += new System.EventHandler(this.btnAcceptOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(295, 388);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(141, 34);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Annuleren";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnBackToDashbaord
            // 
            this.btnBackToDashbaord.Location = new System.Drawing.Point(647, 12);
            this.btnBackToDashbaord.Name = "btnBackToDashbaord";
            this.btnBackToDashbaord.Size = new System.Drawing.Size(141, 34);
            this.btnBackToDashbaord.TabIndex = 7;
            this.btnBackToDashbaord.Text = "Terug naar Dashboard";
            this.btnBackToDashbaord.UseVisualStyleBackColor = true;
            this.btnBackToDashbaord.Click += new System.EventHandler(this.btnBackToDashbaord_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 175;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountInStockDataGridViewTextBoxColumn
            // 
            this.amountInStockDataGridViewTextBoxColumn.DataPropertyName = "AmountInStock";
            this.amountInStockDataGridViewTextBoxColumn.HeaderText = "Vooraad";
            this.amountInStockDataGridViewTextBoxColumn.Name = "amountInStockDataGridViewTextBoxColumn";
            this.amountInStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderAmount
            // 
            this.OrderAmount.DataPropertyName = "OrderAmount";
            this.OrderAmount.HeaderText = "Voorraad Besteld";
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.ReadOnly = true;
            // 
            // stockStatusDataGridViewTextBoxColumn
            // 
            this.stockStatusDataGridViewTextBoxColumn.DataPropertyName = "StockStatus";
            this.stockStatusDataGridViewTextBoxColumn.HeaderText = "VoorraadStatus";
            this.stockStatusDataGridViewTextBoxColumn.Name = "stockStatusDataGridViewTextBoxColumn";
            this.stockStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToDashbaord);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnAcceptOrder);
            this.Controls.Add(this.dgvProductsOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxLogo);
            this.Name = "OrderForm";
            this.Text = "Bestellingen van Producten";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductsOrders;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button btnAcceptOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnBackToDashbaord;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockStatusDataGridViewTextBoxColumn;
    }
}