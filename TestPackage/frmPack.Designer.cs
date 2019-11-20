namespace TestPackage
{
    partial class frmPack
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
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPack));
            this.packageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.packageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPack = new System.Windows.Forms.Button();
            this.btnEditPack = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.cboSupplies = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddPro = new System.Windows.Forms.Button();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingNavigator)).BeginInit();
            this.packageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(46, 215);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 3;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(46, 189);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 5;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(46, 163);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(57, 13);
            pkgDescLabel.TabIndex = 7;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(46, 138);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(46, 85);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 11;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(46, 112);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(80, 13);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(401, 87);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(78, 13);
            prodNameLabel.TabIndex = 15;
            prodNameLabel.Text = "Product Name:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(401, 116);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(73, 13);
            supNameLabel.TabIndex = 19;
            supNameLabel.Text = "Supply Name:";
            // 
            // packageBindingNavigator
            // 
            this.packageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.packageBindingNavigator.BindingSource = this.packageBindingSource;
            this.packageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.packageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.packageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.packageBindingNavigatorSaveItem});
            this.packageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.packageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.packageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.packageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.packageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.packageBindingNavigator.Name = "packageBindingNavigator";
            this.packageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.packageBindingNavigator.Size = new System.Drawing.Size(862, 25);
            this.packageBindingNavigator.TabIndex = 0;
            this.packageBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TestPackage.Package);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // packageBindingNavigatorSaveItem
            // 
            this.packageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.packageBindingNavigatorSaveItem.Enabled = false;
            this.packageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("packageBindingNavigatorSaveItem.Image")));
            this.packageBindingNavigatorSaveItem.Name = "packageBindingNavigatorSaveItem";
            this.packageBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.packageBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(178, 212);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 6;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(178, 186);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgBasePriceTextBox.TabIndex = 5;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(178, 160);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgDescTextBox.TabIndex = 4;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(178, 134);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgEndDateDateTimePicker.TabIndex = 3;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(178, 82);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgNameTextBox.TabIndex = 1;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(178, 108);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgStartDateDateTimePicker.TabIndex = 2;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(TestPackage.Product);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(TestPackage.Supplier);
            // 
            // btnAddPack
            // 
            this.btnAddPack.Location = new System.Drawing.Point(90, 396);
            this.btnAddPack.Name = "btnAddPack";
            this.btnAddPack.Size = new System.Drawing.Size(93, 23);
            this.btnAddPack.TabIndex = 9;
            this.btnAddPack.Text = "Acept Package";
            this.btnAddPack.UseVisualStyleBackColor = true;
            this.btnAddPack.Click += new System.EventHandler(this.btnAddPack_Click);
            // 
            // btnEditPack
            // 
            this.btnEditPack.Location = new System.Drawing.Point(269, 396);
            this.btnEditPack.Name = "btnEditPack";
            this.btnEditPack.Size = new System.Drawing.Size(119, 23);
            this.btnEditPack.TabIndex = 25;
            this.btnEditPack.Text = "Edit Package";
            this.btnEditPack.UseVisualStyleBackColor = true;
            // 
            // cboProducts
            // 
            this.cboProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(533, 83);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(121, 21);
            this.cboProducts.TabIndex = 7;
            this.cboProducts.SelectedValueChanged += new System.EventHandler(this.CboProducts_SelectedValueChanged);
            // 
            // cboSupplies
            // 
            this.cboSupplies.FormattingEnabled = true;
            this.cboSupplies.Location = new System.Drawing.Point(533, 112);
            this.cboSupplies.Name = "cboSupplies";
            this.cboSupplies.Size = new System.Drawing.Size(252, 21);
            this.cboSupplies.TabIndex = 8;
            this.cboSupplies.SelectedIndexChanged += new System.EventHandler(this.CboSupplies_SelectedIndexChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(396, 189);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(367, 146);
            this.dgvProducts.TabIndex = 26;
            // 
            // btnAddPro
            // 
            this.btnAddPro.Location = new System.Drawing.Point(675, 155);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(110, 23);
            this.btnAddPro.TabIndex = 27;
            this.btnAddPro.Text = "Add Products";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // frmPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 615);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.cboSupplies);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.btnEditPack);
            this.Controls.Add(this.btnAddPack);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Controls.Add(this.packageBindingNavigator);
            this.Name = "frmPack";
            this.Text = "Add Package";
            this.Load += new System.EventHandler(this.FrmPack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingNavigator)).EndInit();
            this.packageBindingNavigator.ResumeLayout(false);
            this.packageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingNavigator packageBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton packageBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button btnAddPack;
        private System.Windows.Forms.Button btnEditPack;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.ComboBox cboSupplies;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddPro;
    }
}

