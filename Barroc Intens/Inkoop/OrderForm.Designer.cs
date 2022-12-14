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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductsOrders = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAcceptOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnBackToDashbaord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::Barroc_Intens.Properties.Resources.Logo6_klein;
            this.pboxLogo.Location = new System.Drawing.Point(16, 15);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(133, 123);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 2;
            this.pboxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
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
            this.dgvProductsOrders.Location = new System.Drawing.Point(197, 74);
            this.dgvProductsOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductsOrders.Name = "dgvProductsOrders";
            this.dgvProductsOrders.ReadOnly = true;
            this.dgvProductsOrders.RowHeadersVisible = false;
            this.dgvProductsOrders.RowHeadersWidth = 51;
            this.dgvProductsOrders.Size = new System.Drawing.Size(853, 383);
            this.dgvProductsOrders.TabIndex = 4;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 175;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountInStockDataGridViewTextBoxColumn
            // 
            this.amountInStockDataGridViewTextBoxColumn.DataPropertyName = "AmountInStock";
            this.amountInStockDataGridViewTextBoxColumn.HeaderText = "Vooraad";
            this.amountInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountInStockDataGridViewTextBoxColumn.Name = "amountInStockDataGridViewTextBoxColumn";
            this.amountInStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountInStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderAmount
            // 
            this.OrderAmount.DataPropertyName = "OrderAmount";
            this.OrderAmount.HeaderText = "Voorraad Besteld";
            this.OrderAmount.MinimumWidth = 6;
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.ReadOnly = true;
            this.OrderAmount.Width = 125;
            // 
            // stockStatusDataGridViewTextBoxColumn
            // 
            this.stockStatusDataGridViewTextBoxColumn.DataPropertyName = "StockStatus";
            this.stockStatusDataGridViewTextBoxColumn.HeaderText = "VoorraadStatus";
            this.stockStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockStatusDataGridViewTextBoxColumn.Name = "stockStatusDataGridViewTextBoxColumn";
            this.stockStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Barroc_Intens.Product);
            // 
            // btnAcceptOrder
            // 
            this.btnAcceptOrder.Location = new System.Drawing.Point(197, 478);
            this.btnAcceptOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcceptOrder.Name = "btnAcceptOrder";
            this.btnAcceptOrder.Size = new System.Drawing.Size(188, 42);
            this.btnAcceptOrder.TabIndex = 5;
            this.btnAcceptOrder.Text = "Accepteren";
            this.btnAcceptOrder.UseVisualStyleBackColor = true;
            this.btnAcceptOrder.Click += new System.EventHandler(this.btnAcceptOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(393, 478);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(188, 42);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Annuleren";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnBackToDashbaord
            // 
            this.btnBackToDashbaord.Location = new System.Drawing.Point(863, 15);
            this.btnBackToDashbaord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToDashbaord.Name = "btnBackToDashbaord";
            this.btnBackToDashbaord.Size = new System.Drawing.Size(188, 42);
            this.btnBackToDashbaord.TabIndex = 7;
            this.btnBackToDashbaord.Text = "Terug naar Dashboard";
            this.btnBackToDashbaord.UseVisualStyleBackColor = true;
            this.btnBackToDashbaord.Click += new System.EventHandler(this.btnBackToDashbaord_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBackToDashbaord);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnAcceptOrder);
            this.Controls.Add(this.dgvProductsOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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