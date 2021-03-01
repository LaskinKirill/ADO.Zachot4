
namespace ADO.Zachot4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineOrderFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.salesOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPersonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.territoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billToAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipMethodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardApprovalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyRateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2017DataSet = new ADO.Zachot4.AdventureWorks2017DataSet();
            this.salesOrderHeaderTableAdapter = new ADO.Zachot4.AdventureWorks2017DataSetTableAdapters.SalesOrderHeaderTableAdapter();
            this.Loadsalesbutton = new System.Windows.Forms.Button();
            this.Newsalesbutton = new System.Windows.Forms.Button();
            this.Permitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesOrderIDDataGridViewTextBoxColumn,
            this.revisionNumberDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.shipDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.onlineOrderFlagDataGridViewCheckBoxColumn,
            this.salesOrderNumberDataGridViewTextBoxColumn,
            this.purchaseOrderNumberDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.salesPersonIDDataGridViewTextBoxColumn,
            this.territoryIDDataGridViewTextBoxColumn,
            this.billToAddressIDDataGridViewTextBoxColumn,
            this.shipToAddressIDDataGridViewTextBoxColumn,
            this.shipMethodIDDataGridViewTextBoxColumn,
            this.creditCardIDDataGridViewTextBoxColumn,
            this.creditCardApprovalCodeDataGridViewTextBoxColumn,
            this.currencyRateIDDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.taxAmtDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.totalDueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesOrderHeaderBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // salesOrderIDDataGridViewTextBoxColumn
            // 
            this.salesOrderIDDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderID";
            this.salesOrderIDDataGridViewTextBoxColumn.HeaderText = "SalesOrderID";
            this.salesOrderIDDataGridViewTextBoxColumn.Name = "salesOrderIDDataGridViewTextBoxColumn";
            this.salesOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // revisionNumberDataGridViewTextBoxColumn
            // 
            this.revisionNumberDataGridViewTextBoxColumn.DataPropertyName = "RevisionNumber";
            this.revisionNumberDataGridViewTextBoxColumn.HeaderText = "RevisionNumber";
            this.revisionNumberDataGridViewTextBoxColumn.Name = "revisionNumberDataGridViewTextBoxColumn";
            this.revisionNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipDateDataGridViewTextBoxColumn
            // 
            this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
            this.shipDateDataGridViewTextBoxColumn.HeaderText = "ShipDate";
            this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            this.shipDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onlineOrderFlagDataGridViewCheckBoxColumn
            // 
            this.onlineOrderFlagDataGridViewCheckBoxColumn.DataPropertyName = "OnlineOrderFlag";
            this.onlineOrderFlagDataGridViewCheckBoxColumn.HeaderText = "OnlineOrderFlag";
            this.onlineOrderFlagDataGridViewCheckBoxColumn.Name = "onlineOrderFlagDataGridViewCheckBoxColumn";
            this.onlineOrderFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // salesOrderNumberDataGridViewTextBoxColumn
            // 
            this.salesOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderNumber";
            this.salesOrderNumberDataGridViewTextBoxColumn.HeaderText = "SalesOrderNumber";
            this.salesOrderNumberDataGridViewTextBoxColumn.Name = "salesOrderNumberDataGridViewTextBoxColumn";
            this.salesOrderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseOrderNumberDataGridViewTextBoxColumn
            // 
            this.purchaseOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "PurchaseOrderNumber";
            this.purchaseOrderNumberDataGridViewTextBoxColumn.HeaderText = "PurchaseOrderNumber";
            this.purchaseOrderNumberDataGridViewTextBoxColumn.Name = "purchaseOrderNumberDataGridViewTextBoxColumn";
            this.purchaseOrderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesPersonIDDataGridViewTextBoxColumn
            // 
            this.salesPersonIDDataGridViewTextBoxColumn.DataPropertyName = "SalesPersonID";
            this.salesPersonIDDataGridViewTextBoxColumn.HeaderText = "SalesPersonID";
            this.salesPersonIDDataGridViewTextBoxColumn.Name = "salesPersonIDDataGridViewTextBoxColumn";
            this.salesPersonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // territoryIDDataGridViewTextBoxColumn
            // 
            this.territoryIDDataGridViewTextBoxColumn.DataPropertyName = "TerritoryID";
            this.territoryIDDataGridViewTextBoxColumn.HeaderText = "TerritoryID";
            this.territoryIDDataGridViewTextBoxColumn.Name = "territoryIDDataGridViewTextBoxColumn";
            this.territoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billToAddressIDDataGridViewTextBoxColumn
            // 
            this.billToAddressIDDataGridViewTextBoxColumn.DataPropertyName = "BillToAddressID";
            this.billToAddressIDDataGridViewTextBoxColumn.HeaderText = "BillToAddressID";
            this.billToAddressIDDataGridViewTextBoxColumn.Name = "billToAddressIDDataGridViewTextBoxColumn";
            this.billToAddressIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToAddressIDDataGridViewTextBoxColumn
            // 
            this.shipToAddressIDDataGridViewTextBoxColumn.DataPropertyName = "ShipToAddressID";
            this.shipToAddressIDDataGridViewTextBoxColumn.HeaderText = "ShipToAddressID";
            this.shipToAddressIDDataGridViewTextBoxColumn.Name = "shipToAddressIDDataGridViewTextBoxColumn";
            this.shipToAddressIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipMethodIDDataGridViewTextBoxColumn
            // 
            this.shipMethodIDDataGridViewTextBoxColumn.DataPropertyName = "ShipMethodID";
            this.shipMethodIDDataGridViewTextBoxColumn.HeaderText = "ShipMethodID";
            this.shipMethodIDDataGridViewTextBoxColumn.Name = "shipMethodIDDataGridViewTextBoxColumn";
            this.shipMethodIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditCardIDDataGridViewTextBoxColumn
            // 
            this.creditCardIDDataGridViewTextBoxColumn.DataPropertyName = "CreditCardID";
            this.creditCardIDDataGridViewTextBoxColumn.HeaderText = "CreditCardID";
            this.creditCardIDDataGridViewTextBoxColumn.Name = "creditCardIDDataGridViewTextBoxColumn";
            this.creditCardIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditCardApprovalCodeDataGridViewTextBoxColumn
            // 
            this.creditCardApprovalCodeDataGridViewTextBoxColumn.DataPropertyName = "CreditCardApprovalCode";
            this.creditCardApprovalCodeDataGridViewTextBoxColumn.HeaderText = "CreditCardApprovalCode";
            this.creditCardApprovalCodeDataGridViewTextBoxColumn.Name = "creditCardApprovalCodeDataGridViewTextBoxColumn";
            this.creditCardApprovalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currencyRateIDDataGridViewTextBoxColumn
            // 
            this.currencyRateIDDataGridViewTextBoxColumn.DataPropertyName = "CurrencyRateID";
            this.currencyRateIDDataGridViewTextBoxColumn.HeaderText = "CurrencyRateID";
            this.currencyRateIDDataGridViewTextBoxColumn.Name = "currencyRateIDDataGridViewTextBoxColumn";
            this.currencyRateIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxAmtDataGridViewTextBoxColumn
            // 
            this.taxAmtDataGridViewTextBoxColumn.DataPropertyName = "TaxAmt";
            this.taxAmtDataGridViewTextBoxColumn.HeaderText = "TaxAmt";
            this.taxAmtDataGridViewTextBoxColumn.Name = "taxAmtDataGridViewTextBoxColumn";
            this.taxAmtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freightDataGridViewTextBoxColumn
            // 
            this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
            this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            this.freightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDueDataGridViewTextBoxColumn
            // 
            this.totalDueDataGridViewTextBoxColumn.DataPropertyName = "TotalDue";
            this.totalDueDataGridViewTextBoxColumn.HeaderText = "TotalDue";
            this.totalDueDataGridViewTextBoxColumn.Name = "totalDueDataGridViewTextBoxColumn";
            this.totalDueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            this.rowguidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesOrderHeaderBindingSource
            // 
            this.salesOrderHeaderBindingSource.DataMember = "SalesOrderHeader";
            this.salesOrderHeaderBindingSource.DataSource = this.adventureWorks2017DataSet;
            this.salesOrderHeaderBindingSource.DataSourceChanged += new System.EventHandler(this.Newsalesbutton_Click);
            // 
            // adventureWorks2017DataSet
            // 
            this.adventureWorks2017DataSet.DataSetName = "AdventureWorks2017DataSet";
            this.adventureWorks2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesOrderHeaderTableAdapter
            // 
            this.salesOrderHeaderTableAdapter.ClearBeforeFill = true;
            // 
            // Loadsalesbutton
            // 
            this.Loadsalesbutton.Location = new System.Drawing.Point(54, 45);
            this.Loadsalesbutton.Name = "Loadsalesbutton";
            this.Loadsalesbutton.Size = new System.Drawing.Size(75, 23);
            this.Loadsalesbutton.TabIndex = 1;
            this.Loadsalesbutton.Text = "Load sales";
            this.Loadsalesbutton.UseVisualStyleBackColor = true;
            this.Loadsalesbutton.Click += new System.EventHandler(this.loadsalesbutton_Click);
            // 
            // Newsalesbutton
            // 
            this.Newsalesbutton.Location = new System.Drawing.Point(199, 45);
            this.Newsalesbutton.Name = "Newsalesbutton";
            this.Newsalesbutton.Size = new System.Drawing.Size(95, 23);
            this.Newsalesbutton.TabIndex = 2;
            this.Newsalesbutton.Text = "New sales data";
            this.Newsalesbutton.UseVisualStyleBackColor = true;
            this.Newsalesbutton.Click += new System.EventHandler(this.Newsalesbutton_Click);
            // 
            // Permitbutton
            // 
            this.Permitbutton.Location = new System.Drawing.Point(339, 45);
            this.Permitbutton.Name = "Permitbutton";
            this.Permitbutton.Size = new System.Drawing.Size(75, 23);
            this.Permitbutton.TabIndex = 3;
            this.Permitbutton.Text = "Data access";
            this.Permitbutton.UseVisualStyleBackColor = true;
            this.Permitbutton.Click += new System.EventHandler(this.Permitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(544, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Permitbutton);
            this.Controls.Add(this.Newsalesbutton);
            this.Controls.Add(this.Loadsalesbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onlineOrderFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn territoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billToAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipToAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipMethodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardApprovalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyRateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Loadsalesbutton;
        private System.Windows.Forms.Button Newsalesbutton;
        private System.Windows.Forms.Button Permitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.BindingSource salesOrderHeaderBindingSource;
        public AdventureWorks2017DataSet adventureWorks2017DataSet;
        public AdventureWorks2017DataSetTableAdapters.SalesOrderHeaderTableAdapter salesOrderHeaderTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

