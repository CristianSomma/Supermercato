namespace Supermercato_SOMMA
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnl_title = new Panel();
            lbl_title = new Label();
            dtg_adminTable = new DataGridView();
            mns_controlsChooser = new MenuStrip();
            mni_AddProduct = new ToolStripMenuItem();
            mni_foodProduct = new ToolStripMenuItem();
            mni_nonFoodProduct = new ToolStripMenuItem();
            mni_editProduct = new ToolStripMenuItem();
            refillStocksToolStripMenuItem = new ToolStripMenuItem();
            mni_deleteProduct = new ToolStripMenuItem();
            pnl_controlsContainer = new Panel();
            pnl_addProduct = new Panel();
            pnl_nonFoodProperties = new Panel();
            chc_productFragile = new CheckBox();
            label12 = new Label();
            nmr_productAgeRestriction = new NumericUpDown();
            btn_addNonFoodProduct = new Button();
            btn_AddFoodProduct = new Button();
            lbl_nonFoodProperties = new Label();
            lbl_foodProperties = new Label();
            pnl_foodProperties = new Panel();
            label10 = new Label();
            dtm_productExpiringDate = new DateTimePicker();
            nmr_productWeight = new NumericUpDown();
            label9 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            lbl_productDiscountPercentage = new Label();
            chc_productIsDiscounted = new CheckBox();
            nmr_productDiscountPercentage = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            nmr_productStock = new NumericUpDown();
            label7 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            nmr_productPrice = new NumericUpDown();
            panel2 = new Panel();
            cmb_productCategory = new ComboBox();
            label1 = new Label();
            pnl_nameBrandInputs = new Panel();
            label11 = new Label();
            txt_productBrand = new TextBox();
            label8 = new Label();
            txt_productName = new TextBox();
            panel12 = new Panel();
            cmb_productEditSelected = new ComboBox();
            pnl_productDateOrAgeImmutable = new Panel();
            lbl_dateOrAgeEdit = new Label();
            pnl_productStockImmutable = new Panel();
            label18 = new Label();
            pnl_productCategoruImmutable = new Panel();
            pnl_productBrandImmutable = new Panel();
            label17 = new Label();
            label24 = new Label();
            label25 = new Label();
            label23 = new Label();
            panel10 = new Panel();
            nmr_productPriceEdit = new NumericUpDown();
            label20 = new Label();
            btn_productEdit = new Button();
            pnl_foodProductEdit = new Panel();
            nmr_productWeightEdit = new NumericUpDown();
            label14 = new Label();
            panel7 = new Panel();
            lbl_percentageEdit = new Label();
            chc_productDiscountedEdit = new CheckBox();
            nmr_productPercentageEdit = new NumericUpDown();
            label13 = new Label();
            pnl_nonFoodProductEdit = new Panel();
            chc_productFragileEdit = new CheckBox();
            pnl_editProduct = new Panel();
            pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_adminTable).BeginInit();
            mns_controlsChooser.SuspendLayout();
            pnl_controlsContainer.SuspendLayout();
            pnl_addProduct.SuspendLayout();
            pnl_nonFoodProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productAgeRestriction).BeginInit();
            pnl_foodProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productWeight).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productDiscountPercentage).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productStock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productPrice).BeginInit();
            panel2.SuspendLayout();
            pnl_nameBrandInputs.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productPriceEdit).BeginInit();
            pnl_foodProductEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productWeightEdit).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productPercentageEdit).BeginInit();
            pnl_nonFoodProductEdit.SuspendLayout();
            pnl_editProduct.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_title
            // 
            pnl_title.Controls.Add(lbl_title);
            pnl_title.Dock = DockStyle.Top;
            pnl_title.Location = new Point(0, 0);
            pnl_title.Name = "pnl_title";
            pnl_title.Size = new Size(1232, 125);
            pnl_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            lbl_title.Dock = DockStyle.Fill;
            lbl_title.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(0, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(1232, 125);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Admin Dashboard";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtg_adminTable
            // 
            dtg_adminTable.AllowUserToAddRows = false;
            dtg_adminTable.AllowUserToDeleteRows = false;
            dtg_adminTable.AllowUserToResizeColumns = false;
            dtg_adminTable.AllowUserToResizeRows = false;
            dtg_adminTable.BackgroundColor = SystemColors.Window;
            dtg_adminTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtg_adminTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtg_adminTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_adminTable.Dock = DockStyle.Top;
            dtg_adminTable.GridColor = SystemColors.ControlDarkDark;
            dtg_adminTable.Location = new Point(0, 125);
            dtg_adminTable.MultiSelect = false;
            dtg_adminTable.Name = "dtg_adminTable";
            dtg_adminTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtg_adminTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtg_adminTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtg_adminTable.ScrollBars = ScrollBars.Vertical;
            dtg_adminTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_adminTable.Size = new Size(1232, 450);
            dtg_adminTable.TabIndex = 1;
            // 
            // mns_controlsChooser
            // 
            mns_controlsChooser.Dock = DockStyle.Fill;
            mns_controlsChooser.ImageScalingSize = new Size(20, 20);
            mns_controlsChooser.Items.AddRange(new ToolStripItem[] { mni_AddProduct, mni_editProduct, mni_deleteProduct });
            mns_controlsChooser.Location = new Point(0, 0);
            mns_controlsChooser.Name = "mns_controlsChooser";
            mns_controlsChooser.Size = new Size(1232, 25);
            mns_controlsChooser.TabIndex = 2;
            mns_controlsChooser.Text = "menuStrip1";
            // 
            // mni_AddProduct
            // 
            mni_AddProduct.DropDownItems.AddRange(new ToolStripItem[] { mni_foodProduct, mni_nonFoodProduct });
            mni_AddProduct.Name = "mni_AddProduct";
            mni_AddProduct.Size = new Size(86, 21);
            mni_AddProduct.Text = "Add Product";
            mni_AddProduct.Click += mni_AddProduct_Click;
            // 
            // mni_foodProduct
            // 
            mni_foodProduct.Name = "mni_foodProduct";
            mni_foodProduct.Size = new Size(174, 22);
            mni_foodProduct.Text = "Food Product";
            mni_foodProduct.Click += mni_foodProduct_Click;
            // 
            // mni_nonFoodProduct
            // 
            mni_nonFoodProduct.Name = "mni_nonFoodProduct";
            mni_nonFoodProduct.Size = new Size(174, 22);
            mni_nonFoodProduct.Text = "Non-Food Product";
            mni_nonFoodProduct.Click += mni_nonFoodProduct_Click;
            // 
            // mni_editProduct
            // 
            mni_editProduct.DropDownItems.AddRange(new ToolStripItem[] { refillStocksToolStripMenuItem });
            mni_editProduct.Name = "mni_editProduct";
            mni_editProduct.Size = new Size(84, 21);
            mni_editProduct.Text = "Edit Product";
            mni_editProduct.Click += mni_editProduct_Click;
            // 
            // refillStocksToolStripMenuItem
            // 
            refillStocksToolStripMenuItem.Name = "refillStocksToolStripMenuItem";
            refillStocksToolStripMenuItem.Size = new Size(137, 22);
            refillStocksToolStripMenuItem.Text = "Refill Stocks";
            // 
            // mni_deleteProduct
            // 
            mni_deleteProduct.Name = "mni_deleteProduct";
            mni_deleteProduct.Size = new Size(97, 21);
            mni_deleteProduct.Text = "Delete Product";
            // 
            // pnl_controlsContainer
            // 
            pnl_controlsContainer.BackColor = Color.IndianRed;
            pnl_controlsContainer.Controls.Add(mns_controlsChooser);
            pnl_controlsContainer.Location = new Point(0, 575);
            pnl_controlsContainer.Name = "pnl_controlsContainer";
            pnl_controlsContainer.Size = new Size(1232, 25);
            pnl_controlsContainer.TabIndex = 3;
            // 
            // pnl_addProduct
            // 
            pnl_addProduct.BackColor = Color.FromArgb(255, 224, 192);
            pnl_addProduct.Controls.Add(pnl_nonFoodProperties);
            pnl_addProduct.Controls.Add(btn_addNonFoodProduct);
            pnl_addProduct.Controls.Add(btn_AddFoodProduct);
            pnl_addProduct.Controls.Add(lbl_nonFoodProperties);
            pnl_addProduct.Controls.Add(lbl_foodProperties);
            pnl_addProduct.Controls.Add(pnl_foodProperties);
            pnl_addProduct.Controls.Add(label5);
            pnl_addProduct.Controls.Add(panel4);
            pnl_addProduct.Controls.Add(label4);
            pnl_addProduct.Controls.Add(label2);
            pnl_addProduct.Controls.Add(panel3);
            pnl_addProduct.Controls.Add(label3);
            pnl_addProduct.Controls.Add(panel1);
            pnl_addProduct.Controls.Add(panel2);
            pnl_addProduct.Controls.Add(label1);
            pnl_addProduct.Controls.Add(pnl_nameBrandInputs);
            pnl_addProduct.Location = new Point(0, 606);
            pnl_addProduct.Name = "pnl_addProduct";
            pnl_addProduct.Size = new Size(1232, 287);
            pnl_addProduct.TabIndex = 3;
            // 
            // pnl_nonFoodProperties
            // 
            pnl_nonFoodProperties.BackColor = SystemColors.MenuBar;
            pnl_nonFoodProperties.Controls.Add(chc_productFragile);
            pnl_nonFoodProperties.Controls.Add(label12);
            pnl_nonFoodProperties.Controls.Add(nmr_productAgeRestriction);
            pnl_nonFoodProperties.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_nonFoodProperties.Location = new Point(1000, 122);
            pnl_nonFoodProperties.Name = "pnl_nonFoodProperties";
            pnl_nonFoodProperties.Size = new Size(300, 153);
            pnl_nonFoodProperties.TabIndex = 14;
            // 
            // chc_productFragile
            // 
            chc_productFragile.Location = new Point(15, 10);
            chc_productFragile.Name = "chc_productFragile";
            chc_productFragile.Size = new Size(266, 32);
            chc_productFragile.TabIndex = 9;
            chc_productFragile.Text = "Fragile";
            chc_productFragile.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 72);
            label12.Name = "label12";
            label12.Size = new Size(147, 23);
            label12.TabIndex = 13;
            label12.Text = "Age restriction:*";
            // 
            // nmr_productAgeRestriction
            // 
            nmr_productAgeRestriction.Location = new Point(15, 103);
            nmr_productAgeRestriction.Maximum = new decimal(new int[] { 17, 0, 0, 0 });
            nmr_productAgeRestriction.Name = "nmr_productAgeRestriction";
            nmr_productAgeRestriction.Size = new Size(266, 30);
            nmr_productAgeRestriction.TabIndex = 11;
            nmr_productAgeRestriction.TextAlign = HorizontalAlignment.Center;
            nmr_productAgeRestriction.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_addNonFoodProduct
            // 
            btn_addNonFoodProduct.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addNonFoodProduct.Location = new Point(1000, 32);
            btn_addNonFoodProduct.Name = "btn_addNonFoodProduct";
            btn_addNonFoodProduct.Size = new Size(200, 60);
            btn_addNonFoodProduct.TabIndex = 15;
            btn_addNonFoodProduct.Text = "Add";
            btn_addNonFoodProduct.UseVisualStyleBackColor = true;
            btn_addNonFoodProduct.Visible = false;
            btn_addNonFoodProduct.Click += btn_addNonFoodProduct_Click;
            // 
            // btn_AddFoodProduct
            // 
            btn_AddFoodProduct.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddFoodProduct.Location = new Point(1000, 32);
            btn_AddFoodProduct.Name = "btn_AddFoodProduct";
            btn_AddFoodProduct.Size = new Size(200, 60);
            btn_AddFoodProduct.TabIndex = 12;
            btn_AddFoodProduct.Text = "Add";
            btn_AddFoodProduct.UseVisualStyleBackColor = true;
            btn_AddFoodProduct.Visible = false;
            btn_AddFoodProduct.Click += btn_AddFoodProduct_Click;
            // 
            // lbl_nonFoodProperties
            // 
            lbl_nonFoodProperties.AutoSize = true;
            lbl_nonFoodProperties.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_nonFoodProperties.Location = new Point(676, 98);
            lbl_nonFoodProperties.Name = "lbl_nonFoodProperties";
            lbl_nonFoodProperties.Size = new Size(139, 17);
            lbl_nonFoodProperties.TabIndex = 13;
            lbl_nonFoodProperties.Text = "Non-Food Properties:";
            lbl_nonFoodProperties.Visible = false;
            // 
            // lbl_foodProperties
            // 
            lbl_foodProperties.AutoSize = true;
            lbl_foodProperties.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_foodProperties.Location = new Point(676, 98);
            lbl_foodProperties.Name = "lbl_foodProperties";
            lbl_foodProperties.Size = new Size(109, 17);
            lbl_foodProperties.TabIndex = 11;
            lbl_foodProperties.Text = "Food Properties:";
            lbl_foodProperties.Visible = false;
            // 
            // pnl_foodProperties
            // 
            pnl_foodProperties.BackColor = SystemColors.MenuBar;
            pnl_foodProperties.Controls.Add(label10);
            pnl_foodProperties.Controls.Add(dtm_productExpiringDate);
            pnl_foodProperties.Controls.Add(nmr_productWeight);
            pnl_foodProperties.Controls.Add(label9);
            pnl_foodProperties.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_foodProperties.Location = new Point(676, 122);
            pnl_foodProperties.Name = "pnl_foodProperties";
            pnl_foodProperties.Size = new Size(300, 153);
            pnl_foodProperties.TabIndex = 1;
            pnl_foodProperties.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 72);
            label10.Name = "label10";
            label10.Size = new Size(138, 23);
            label10.TabIndex = 13;
            label10.Text = "Expiring date:*";
            // 
            // dtm_productExpiringDate
            // 
            dtm_productExpiringDate.Format = DateTimePickerFormat.Short;
            dtm_productExpiringDate.Location = new Point(15, 103);
            dtm_productExpiringDate.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtm_productExpiringDate.Name = "dtm_productExpiringDate";
            dtm_productExpiringDate.Size = new Size(266, 30);
            dtm_productExpiringDate.TabIndex = 12;
            // 
            // nmr_productWeight
            // 
            nmr_productWeight.DecimalPlaces = 2;
            nmr_productWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nmr_productWeight.Location = new Point(131, 9);
            nmr_productWeight.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nmr_productWeight.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nmr_productWeight.Name = "nmr_productWeight";
            nmr_productWeight.Size = new Size(150, 30);
            nmr_productWeight.TabIndex = 11;
            nmr_productWeight.TextAlign = HorizontalAlignment.Center;
            nmr_productWeight.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 11);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 10;
            label9.Text = "Weight:*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(28, 191);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 10;
            label5.Text = "Discount:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuBar;
            panel4.Controls.Add(lbl_productDiscountPercentage);
            panel4.Controls.Add(chc_productIsDiscounted);
            panel4.Controls.Add(nmr_productDiscountPercentage);
            panel4.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(28, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 60);
            panel4.TabIndex = 9;
            // 
            // lbl_productDiscountPercentage
            // 
            lbl_productDiscountPercentage.AutoSize = true;
            lbl_productDiscountPercentage.Location = new Point(271, 16);
            lbl_productDiscountPercentage.Name = "lbl_productDiscountPercentage";
            lbl_productDiscountPercentage.Size = new Size(121, 23);
            lbl_productDiscountPercentage.TabIndex = 8;
            lbl_productDiscountPercentage.Text = "Percentage:*";
            lbl_productDiscountPercentage.Visible = false;
            // 
            // chc_productIsDiscounted
            // 
            chc_productIsDiscounted.Location = new Point(87, 16);
            chc_productIsDiscounted.Name = "chc_productIsDiscounted";
            chc_productIsDiscounted.Size = new Size(126, 32);
            chc_productIsDiscounted.TabIndex = 0;
            chc_productIsDiscounted.Text = "Discount";
            chc_productIsDiscounted.UseVisualStyleBackColor = true;
            chc_productIsDiscounted.CheckedChanged += chc_productIsDiscounted_CheckedChanged;
            // 
            // nmr_productDiscountPercentage
            // 
            nmr_productDiscountPercentage.Location = new Point(424, 13);
            nmr_productDiscountPercentage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_productDiscountPercentage.Name = "nmr_productDiscountPercentage";
            nmr_productDiscountPercentage.Size = new Size(175, 30);
            nmr_productDiscountPercentage.TabIndex = 7;
            nmr_productDiscountPercentage.TextAlign = HorizontalAlignment.Center;
            nmr_productDiscountPercentage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_productDiscountPercentage.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(676, 8);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 3;
            label4.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(352, 98);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 6;
            label2.Text = "Price:*";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuBar;
            panel3.Controls.Add(nmr_productStock);
            panel3.Controls.Add(label7);
            panel3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(676, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 60);
            panel3.TabIndex = 2;
            // 
            // nmr_productStock
            // 
            nmr_productStock.Location = new Point(131, 11);
            nmr_productStock.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nmr_productStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_productStock.Name = "nmr_productStock";
            nmr_productStock.Size = new Size(150, 30);
            nmr_productStock.TabIndex = 9;
            nmr_productStock.TextAlign = HorizontalAlignment.Center;
            nmr_productStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 13);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 0;
            label7.Text = "In stock:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(352, 8);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 3;
            label3.Text = "Category:*";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(nmr_productPrice);
            panel1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(352, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 60);
            panel1.TabIndex = 5;
            // 
            // nmr_productPrice
            // 
            nmr_productPrice.DecimalPlaces = 2;
            nmr_productPrice.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nmr_productPrice.Location = new Point(25, 12);
            nmr_productPrice.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nmr_productPrice.Name = "nmr_productPrice";
            nmr_productPrice.Size = new Size(250, 30);
            nmr_productPrice.TabIndex = 8;
            nmr_productPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuBar;
            panel2.Controls.Add(cmb_productCategory);
            panel2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(352, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 60);
            panel2.TabIndex = 2;
            // 
            // cmb_productCategory
            // 
            cmb_productCategory.FormattingEnabled = true;
            cmb_productCategory.Location = new Point(25, 10);
            cmb_productCategory.Name = "cmb_productCategory";
            cmb_productCategory.Size = new Size(250, 30);
            cmb_productCategory.TabIndex = 4;
            cmb_productCategory.SelectedIndexChanged += cmb_productCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 8);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 1;
            label1.Text = "Identifiers:";
            // 
            // pnl_nameBrandInputs
            // 
            pnl_nameBrandInputs.BackColor = SystemColors.MenuBar;
            pnl_nameBrandInputs.Controls.Add(label11);
            pnl_nameBrandInputs.Controls.Add(txt_productBrand);
            pnl_nameBrandInputs.Controls.Add(label8);
            pnl_nameBrandInputs.Controls.Add(txt_productName);
            pnl_nameBrandInputs.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_nameBrandInputs.Location = new Point(28, 32);
            pnl_nameBrandInputs.Name = "pnl_nameBrandInputs";
            pnl_nameBrandInputs.Size = new Size(300, 150);
            pnl_nameBrandInputs.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 104);
            label11.Name = "label11";
            label11.Size = new Size(67, 23);
            label11.TabIndex = 16;
            label11.Text = "Brand:";
            // 
            // txt_productBrand
            // 
            txt_productBrand.Location = new Point(100, 101);
            txt_productBrand.Name = "txt_productBrand";
            txt_productBrand.Size = new Size(185, 30);
            txt_productBrand.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 13);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 14;
            label8.Text = "Name:*";
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(100, 11);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(185, 30);
            txt_productName.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.MenuBar;
            panel12.Controls.Add(cmb_productEditSelected);
            panel12.Controls.Add(pnl_productDateOrAgeImmutable);
            panel12.Controls.Add(lbl_dateOrAgeEdit);
            panel12.Controls.Add(pnl_productStockImmutable);
            panel12.Controls.Add(label18);
            panel12.Controls.Add(pnl_productCategoruImmutable);
            panel12.Controls.Add(pnl_productBrandImmutable);
            panel12.Controls.Add(label17);
            panel12.Controls.Add(label24);
            panel12.Controls.Add(label25);
            panel12.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel12.Location = new Point(28, 32);
            panel12.Name = "panel12";
            panel12.Size = new Size(624, 243);
            panel12.TabIndex = 0;
            // 
            // cmb_productEditSelected
            // 
            cmb_productEditSelected.FormattingEnabled = true;
            cmb_productEditSelected.Location = new Point(11, 51);
            cmb_productEditSelected.Name = "cmb_productEditSelected";
            cmb_productEditSelected.Size = new Size(274, 30);
            cmb_productEditSelected.TabIndex = 5;
            // 
            // pnl_productDateOrAgeImmutable
            // 
            pnl_productDateOrAgeImmutable.BackColor = Color.White;
            pnl_productDateOrAgeImmutable.Location = new Point(325, 121);
            pnl_productDateOrAgeImmutable.Name = "pnl_productDateOrAgeImmutable";
            pnl_productDateOrAgeImmutable.Size = new Size(274, 35);
            pnl_productDateOrAgeImmutable.TabIndex = 23;
            // 
            // lbl_dateOrAgeEdit
            // 
            lbl_dateOrAgeEdit.AutoSize = true;
            lbl_dateOrAgeEdit.Location = new Point(325, 90);
            lbl_dateOrAgeEdit.Name = "lbl_dateOrAgeEdit";
            lbl_dateOrAgeEdit.Size = new Size(128, 23);
            lbl_dateOrAgeEdit.TabIndex = 22;
            lbl_dateOrAgeEdit.Text = "Expiring date:";
            // 
            // pnl_productStockImmutable
            // 
            pnl_productStockImmutable.BackColor = Color.White;
            pnl_productStockImmutable.Location = new Point(325, 52);
            pnl_productStockImmutable.Name = "pnl_productStockImmutable";
            pnl_productStockImmutable.Size = new Size(274, 35);
            pnl_productStockImmutable.TabIndex = 21;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(325, 21);
            label18.Name = "label18";
            label18.Size = new Size(86, 23);
            label18.TabIndex = 20;
            label18.Text = "In Stock:";
            // 
            // pnl_productCategoruImmutable
            // 
            pnl_productCategoruImmutable.BackColor = Color.White;
            pnl_productCategoruImmutable.Location = new Point(11, 187);
            pnl_productCategoruImmutable.Name = "pnl_productCategoruImmutable";
            pnl_productCategoruImmutable.Size = new Size(274, 35);
            pnl_productCategoruImmutable.TabIndex = 19;
            // 
            // pnl_productBrandImmutable
            // 
            pnl_productBrandImmutable.BackColor = Color.White;
            pnl_productBrandImmutable.Location = new Point(11, 121);
            pnl_productBrandImmutable.Name = "pnl_productBrandImmutable";
            pnl_productBrandImmutable.Size = new Size(274, 35);
            pnl_productBrandImmutable.TabIndex = 18;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 156);
            label17.Name = "label17";
            label17.Size = new Size(91, 23);
            label17.TabIndex = 17;
            label17.Text = "Category:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(10, 90);
            label24.Name = "label24";
            label24.Size = new Size(67, 23);
            label24.TabIndex = 16;
            label24.Text = "Brand:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(10, 21);
            label25.Name = "label25";
            label25.Size = new Size(66, 23);
            label25.TabIndex = 14;
            label25.Text = "Name:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label23.Location = new Point(28, 8);
            label23.Name = "label23";
            label23.Size = new Size(143, 17);
            label23.TabIndex = 1;
            label23.Text = "Immutable properties:";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.MenuBar;
            panel10.Controls.Add(nmr_productPriceEdit);
            panel10.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel10.Location = new Point(676, 32);
            panel10.Name = "panel10";
            panel10.Size = new Size(300, 60);
            panel10.TabIndex = 5;
            // 
            // nmr_productPriceEdit
            // 
            nmr_productPriceEdit.DecimalPlaces = 2;
            nmr_productPriceEdit.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nmr_productPriceEdit.Location = new Point(15, 12);
            nmr_productPriceEdit.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nmr_productPriceEdit.Name = "nmr_productPriceEdit";
            nmr_productPriceEdit.Size = new Size(266, 30);
            nmr_productPriceEdit.TabIndex = 8;
            nmr_productPriceEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label20.Location = new Point(676, 8);
            label20.Name = "label20";
            label20.Size = new Size(42, 17);
            label20.TabIndex = 6;
            label20.Text = "Price:";
            // 
            // btn_productEdit
            // 
            btn_productEdit.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_productEdit.Location = new Point(1000, 32);
            btn_productEdit.Name = "btn_productEdit";
            btn_productEdit.Size = new Size(200, 60);
            btn_productEdit.TabIndex = 12;
            btn_productEdit.Text = "Edit";
            btn_productEdit.UseVisualStyleBackColor = true;
            btn_productEdit.Visible = false;
            // 
            // pnl_foodProductEdit
            // 
            pnl_foodProductEdit.BackColor = SystemColors.MenuBar;
            pnl_foodProductEdit.Controls.Add(nmr_productWeightEdit);
            pnl_foodProductEdit.Controls.Add(label14);
            pnl_foodProductEdit.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_foodProductEdit.Location = new Point(676, 119);
            pnl_foodProductEdit.Name = "pnl_foodProductEdit";
            pnl_foodProductEdit.Size = new Size(300, 60);
            pnl_foodProductEdit.TabIndex = 10;
            pnl_foodProductEdit.Visible = false;
            // 
            // nmr_productWeightEdit
            // 
            nmr_productWeightEdit.DecimalPlaces = 2;
            nmr_productWeightEdit.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nmr_productWeightEdit.Location = new Point(131, 11);
            nmr_productWeightEdit.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nmr_productWeightEdit.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nmr_productWeightEdit.Name = "nmr_productWeightEdit";
            nmr_productWeightEdit.Size = new Size(150, 30);
            nmr_productWeightEdit.TabIndex = 15;
            nmr_productWeightEdit.TextAlign = HorizontalAlignment.Center;
            nmr_productWeightEdit.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 13);
            label14.Name = "label14";
            label14.Size = new Size(76, 23);
            label14.TabIndex = 14;
            label14.Text = "Weight:";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.MenuBar;
            panel7.Controls.Add(lbl_percentageEdit);
            panel7.Controls.Add(chc_productDiscountedEdit);
            panel7.Controls.Add(nmr_productPercentageEdit);
            panel7.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(676, 212);
            panel7.Name = "panel7";
            panel7.Size = new Size(524, 60);
            panel7.TabIndex = 11;
            // 
            // lbl_percentageEdit
            // 
            lbl_percentageEdit.AutoSize = true;
            lbl_percentageEdit.Location = new Point(174, 15);
            lbl_percentageEdit.Name = "lbl_percentageEdit";
            lbl_percentageEdit.Size = new Size(121, 23);
            lbl_percentageEdit.TabIndex = 8;
            lbl_percentageEdit.Text = "Percentage:*";
            lbl_percentageEdit.Visible = false;
            // 
            // chc_productDiscountedEdit
            // 
            chc_productDiscountedEdit.Location = new Point(15, 14);
            chc_productDiscountedEdit.Name = "chc_productDiscountedEdit";
            chc_productDiscountedEdit.Size = new Size(126, 32);
            chc_productDiscountedEdit.TabIndex = 0;
            chc_productDiscountedEdit.Text = "Discount";
            chc_productDiscountedEdit.UseVisualStyleBackColor = true;
            // 
            // nmr_productPercentageEdit
            // 
            nmr_productPercentageEdit.Location = new Point(327, 12);
            nmr_productPercentageEdit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_productPercentageEdit.Name = "nmr_productPercentageEdit";
            nmr_productPercentageEdit.Size = new Size(175, 30);
            nmr_productPercentageEdit.TabIndex = 7;
            nmr_productPercentageEdit.TextAlign = HorizontalAlignment.Center;
            nmr_productPercentageEdit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_productPercentageEdit.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(676, 188);
            label13.Name = "label13";
            label13.Size = new Size(67, 17);
            label13.TabIndex = 12;
            label13.Text = "Discount:";
            // 
            // pnl_nonFoodProductEdit
            // 
            pnl_nonFoodProductEdit.BackColor = SystemColors.MenuBar;
            pnl_nonFoodProductEdit.Controls.Add(chc_productFragileEdit);
            pnl_nonFoodProductEdit.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_nonFoodProductEdit.Location = new Point(1000, 122);
            pnl_nonFoodProductEdit.Name = "pnl_nonFoodProductEdit";
            pnl_nonFoodProductEdit.Size = new Size(300, 60);
            pnl_nonFoodProductEdit.TabIndex = 16;
            pnl_nonFoodProductEdit.Visible = false;
            // 
            // chc_productFragileEdit
            // 
            chc_productFragileEdit.Location = new Point(15, 9);
            chc_productFragileEdit.Name = "chc_productFragileEdit";
            chc_productFragileEdit.Size = new Size(266, 32);
            chc_productFragileEdit.TabIndex = 14;
            chc_productFragileEdit.Text = "Fragile";
            chc_productFragileEdit.UseVisualStyleBackColor = true;
            // 
            // pnl_editProduct
            // 
            pnl_editProduct.BackColor = Color.FromArgb(192, 255, 192);
            pnl_editProduct.Controls.Add(pnl_nonFoodProductEdit);
            pnl_editProduct.Controls.Add(label13);
            pnl_editProduct.Controls.Add(panel7);
            pnl_editProduct.Controls.Add(pnl_foodProductEdit);
            pnl_editProduct.Controls.Add(btn_productEdit);
            pnl_editProduct.Controls.Add(label20);
            pnl_editProduct.Controls.Add(panel10);
            pnl_editProduct.Controls.Add(label23);
            pnl_editProduct.Controls.Add(panel12);
            pnl_editProduct.Location = new Point(0, 282);
            pnl_editProduct.Name = "pnl_editProduct";
            pnl_editProduct.Size = new Size(1232, 287);
            pnl_editProduct.TabIndex = 4;
            pnl_editProduct.Visible = false;
            // 
            // AdminForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1232, 890);
            Controls.Add(pnl_addProduct);
            Controls.Add(pnl_controlsContainer);
            Controls.Add(pnl_editProduct);
            Controls.Add(dtg_adminTable);
            Controls.Add(pnl_title);
            Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = mns_controlsChooser;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += AdminForm_Load;
            pnl_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_adminTable).EndInit();
            mns_controlsChooser.ResumeLayout(false);
            mns_controlsChooser.PerformLayout();
            pnl_controlsContainer.ResumeLayout(false);
            pnl_controlsContainer.PerformLayout();
            pnl_addProduct.ResumeLayout(false);
            pnl_addProduct.PerformLayout();
            pnl_nonFoodProperties.ResumeLayout(false);
            pnl_nonFoodProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productAgeRestriction).EndInit();
            pnl_foodProperties.ResumeLayout(false);
            pnl_foodProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productWeight).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productDiscountPercentage).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productStock).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmr_productPrice).EndInit();
            panel2.ResumeLayout(false);
            pnl_nameBrandInputs.ResumeLayout(false);
            pnl_nameBrandInputs.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmr_productPriceEdit).EndInit();
            pnl_foodProductEdit.ResumeLayout(false);
            pnl_foodProductEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productWeightEdit).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productPercentageEdit).EndInit();
            pnl_nonFoodProductEdit.ResumeLayout(false);
            pnl_editProduct.ResumeLayout(false);
            pnl_editProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_title;
        private Label lbl_title;
        private DataGridView dtg_adminTable;
        private MenuStrip mns_controlsChooser;
        private ToolStripMenuItem mni_AddProduct;
        private ToolStripMenuItem mni_editProduct;
        private ToolStripMenuItem mni_deleteProduct;
        private Panel pnl_controlsContainer;
        private Panel pnl_addProduct;
        private Label label1;
        private Panel pnl_nameBrandInputs;
        private Label label3;
        private Panel panel2;
        private ComboBox cmb_productCategory;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Panel panel3;
        private CheckBox chc_productIsDiscounted;
        private NumericUpDown nmr_productDiscountPercentage;
        private NumericUpDown nmr_productPrice;
        private Label label5;
        private Panel panel4;
        private Label lbl_productDiscountPercentage;
        private NumericUpDown nmr_productStock;
        private Label label7;
        private ToolStripMenuItem mni_foodProduct;
        private ToolStripMenuItem mni_nonFoodProduct;
        private ToolStripMenuItem refillStocksToolStripMenuItem;
        private Label lbl_foodProperties;
        private Panel pnl_foodProperties;
        private NumericUpDown nmr_productWeight;
        private Label label9;
        private Label label10;
        private DateTimePicker dtm_productExpiringDate;
        private TextBox txt_productName;
        private Label label8;
        private Button btn_AddFoodProduct;
        private Label label11;
        private TextBox txt_productBrand;
        private Label lbl_nonFoodProperties;
        private Panel pnl_nonFoodProperties;
        private Label label12;
        private NumericUpDown nmr_productAgeRestriction;
        private CheckBox chc_productFragile;
        private Button btn_addNonFoodProduct;
        private Panel panel12;
        private ComboBox cmb_productEditSelected;
        private Panel pnl_productDateOrAgeImmutable;
        private Label lbl_dateOrAgeEdit;
        private Panel pnl_productStockImmutable;
        private Label label18;
        private Panel pnl_productCategoruImmutable;
        private Panel pnl_productBrandImmutable;
        private Label label17;
        private Label label24;
        private Label label25;
        private Label label23;
        private Panel panel10;
        private NumericUpDown nmr_productPriceEdit;
        private Label label20;
        private Button btn_productEdit;
        private Panel pnl_foodProductEdit;
        private NumericUpDown nmr_productWeightEdit;
        private Label label14;
        private Panel panel7;
        private Label lbl_percentageEdit;
        private CheckBox chc_productDiscountedEdit;
        private NumericUpDown nmr_productPercentageEdit;
        private Label label13;
        private Panel pnl_nonFoodProductEdit;
        private CheckBox chc_productFragileEdit;
        private Panel pnl_editProduct;
    }
}