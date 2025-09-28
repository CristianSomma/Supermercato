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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnl_title = new Panel();
            lbl_title = new Label();
            dtg_adminTable = new DataGridView();
            mns_controlsChooser = new MenuStrip();
            mni_AddProduct = new ToolStripMenuItem();
            mni_foodProduct = new ToolStripMenuItem();
            mni_nonFoodProduct = new ToolStripMenuItem();
            editProductToolStripMenuItem = new ToolStripMenuItem();
            refillStocksToolStripMenuItem = new ToolStripMenuItem();
            deleteProductToolStripMenuItem = new ToolStripMenuItem();
            pnl_controlsContainer = new Panel();
            pnl_addControlsContainer = new Panel();
            pnl_nonFoodProperties = new Panel();
            checkBox2 = new CheckBox();
            label12 = new Label();
            numericUpDown5 = new NumericUpDown();
            btn_AddProduct = new Button();
            lbl_nonFoodProperties = new Label();
            lbl_foodProperties = new Label();
            pnl_foodProperties = new Panel();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown4 = new NumericUpDown();
            label9 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            numericUpDown2 = new NumericUpDown();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            pnl_nameBrandInputs = new Panel();
            label11 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_adminTable).BeginInit();
            mns_controlsChooser.SuspendLayout();
            pnl_controlsContainer.SuspendLayout();
            pnl_addControlsContainer.SuspendLayout();
            pnl_nonFoodProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            pnl_foodProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel2.SuspendLayout();
            pnl_nameBrandInputs.SuspendLayout();
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
            lbl_title.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_adminTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_adminTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_adminTable.Dock = DockStyle.Top;
            dtg_adminTable.GridColor = SystemColors.ControlDarkDark;
            dtg_adminTable.Location = new Point(0, 125);
            dtg_adminTable.MultiSelect = false;
            dtg_adminTable.Name = "dtg_adminTable";
            dtg_adminTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtg_adminTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg_adminTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtg_adminTable.ScrollBars = ScrollBars.Vertical;
            dtg_adminTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_adminTable.Size = new Size(1232, 450);
            dtg_adminTable.TabIndex = 1;
            // 
            // mns_controlsChooser
            // 
            mns_controlsChooser.ImageScalingSize = new Size(20, 20);
            mns_controlsChooser.Items.AddRange(new ToolStripItem[] { mni_AddProduct, editProductToolStripMenuItem, deleteProductToolStripMenuItem });
            mns_controlsChooser.Location = new Point(0, 0);
            mns_controlsChooser.Name = "mns_controlsChooser";
            mns_controlsChooser.Size = new Size(1232, 28);
            mns_controlsChooser.TabIndex = 2;
            mns_controlsChooser.Text = "menuStrip1";
            // 
            // mni_AddProduct
            // 
            mni_AddProduct.DropDownItems.AddRange(new ToolStripItem[] { mni_foodProduct, mni_nonFoodProduct });
            mni_AddProduct.Name = "mni_AddProduct";
            mni_AddProduct.Size = new Size(106, 24);
            mni_AddProduct.Text = "Add Product";
            mni_AddProduct.Click += mni_AddProduct_Click;
            // 
            // mni_foodProduct
            // 
            mni_foodProduct.Name = "mni_foodProduct";
            mni_foodProduct.Size = new Size(215, 26);
            mni_foodProduct.Text = "Food Product";
            mni_foodProduct.Click += mni_foodProduct_Click;
            // 
            // mni_nonFoodProduct
            // 
            mni_nonFoodProduct.Name = "mni_nonFoodProduct";
            mni_nonFoodProduct.Size = new Size(215, 26);
            mni_nonFoodProduct.Text = "Non-Food Product";
            mni_nonFoodProduct.Click += mni_nonFoodProduct_Click;
            // 
            // editProductToolStripMenuItem
            // 
            editProductToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refillStocksToolStripMenuItem });
            editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            editProductToolStripMenuItem.Size = new Size(104, 24);
            editProductToolStripMenuItem.Text = "Edit Product";
            // 
            // refillStocksToolStripMenuItem
            // 
            refillStocksToolStripMenuItem.Name = "refillStocksToolStripMenuItem";
            refillStocksToolStripMenuItem.Size = new Size(172, 26);
            refillStocksToolStripMenuItem.Text = "Refill Stocks";
            // 
            // deleteProductToolStripMenuItem
            // 
            deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            deleteProductToolStripMenuItem.Size = new Size(122, 24);
            deleteProductToolStripMenuItem.Text = "Delete Product";
            // 
            // pnl_controlsContainer
            // 
            pnl_controlsContainer.Controls.Add(pnl_addControlsContainer);
            pnl_controlsContainer.Controls.Add(mns_controlsChooser);
            pnl_controlsContainer.Dock = DockStyle.Fill;
            pnl_controlsContainer.Location = new Point(0, 575);
            pnl_controlsContainer.Name = "pnl_controlsContainer";
            pnl_controlsContainer.Size = new Size(1232, 315);
            pnl_controlsContainer.TabIndex = 3;
            // 
            // pnl_addControlsContainer
            // 
            pnl_addControlsContainer.BackColor = Color.FromArgb(255, 224, 192);
            pnl_addControlsContainer.Controls.Add(pnl_nonFoodProperties);
            pnl_addControlsContainer.Controls.Add(btn_AddProduct);
            pnl_addControlsContainer.Controls.Add(lbl_nonFoodProperties);
            pnl_addControlsContainer.Controls.Add(lbl_foodProperties);
            pnl_addControlsContainer.Controls.Add(pnl_foodProperties);
            pnl_addControlsContainer.Controls.Add(label5);
            pnl_addControlsContainer.Controls.Add(panel4);
            pnl_addControlsContainer.Controls.Add(label4);
            pnl_addControlsContainer.Controls.Add(label2);
            pnl_addControlsContainer.Controls.Add(panel3);
            pnl_addControlsContainer.Controls.Add(label3);
            pnl_addControlsContainer.Controls.Add(panel1);
            pnl_addControlsContainer.Controls.Add(panel2);
            pnl_addControlsContainer.Controls.Add(label1);
            pnl_addControlsContainer.Controls.Add(pnl_nameBrandInputs);
            pnl_addControlsContainer.Dock = DockStyle.Fill;
            pnl_addControlsContainer.Location = new Point(0, 28);
            pnl_addControlsContainer.Name = "pnl_addControlsContainer";
            pnl_addControlsContainer.Size = new Size(1232, 287);
            pnl_addControlsContainer.TabIndex = 3;
            // 
            // pnl_nonFoodProperties
            // 
            pnl_nonFoodProperties.BackColor = SystemColors.MenuBar;
            pnl_nonFoodProperties.Controls.Add(checkBox2);
            pnl_nonFoodProperties.Controls.Add(label12);
            pnl_nonFoodProperties.Controls.Add(numericUpDown5);
            pnl_nonFoodProperties.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnl_nonFoodProperties.Location = new Point(676, 122);
            pnl_nonFoodProperties.Name = "pnl_nonFoodProperties";
            pnl_nonFoodProperties.Size = new Size(300, 153);
            pnl_nonFoodProperties.TabIndex = 14;
            // 
            // checkBox2
            // 
            checkBox2.Location = new Point(15, 10);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(266, 32);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Fragile";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 72);
            label12.Name = "label12";
            label12.Size = new Size(179, 28);
            label12.TabIndex = 13;
            label12.Text = "Age restriction:*";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(15, 103);
            numericUpDown5.Maximum = new decimal(new int[] { 17, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(266, 35);
            numericUpDown5.TabIndex = 11;
            numericUpDown5.TextAlign = HorizontalAlignment.Center;
            numericUpDown5.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AddProduct.Location = new Point(1000, 32);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(200, 60);
            btn_AddProduct.TabIndex = 12;
            btn_AddProduct.Text = "Add";
            btn_AddProduct.UseVisualStyleBackColor = true;
            // 
            // lbl_nonFoodProperties
            // 
            lbl_nonFoodProperties.AutoSize = true;
            lbl_nonFoodProperties.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_nonFoodProperties.Location = new Point(676, 98);
            lbl_nonFoodProperties.Name = "lbl_nonFoodProperties";
            lbl_nonFoodProperties.Size = new Size(167, 21);
            lbl_nonFoodProperties.TabIndex = 13;
            lbl_nonFoodProperties.Text = "Non-Food Properties:";
            lbl_nonFoodProperties.Visible = false;
            // 
            // lbl_foodProperties
            // 
            lbl_foodProperties.AutoSize = true;
            lbl_foodProperties.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_foodProperties.Location = new Point(676, 98);
            lbl_foodProperties.Name = "lbl_foodProperties";
            lbl_foodProperties.Size = new Size(132, 21);
            lbl_foodProperties.TabIndex = 11;
            lbl_foodProperties.Text = "Food Properties:";
            lbl_foodProperties.Visible = false;
            // 
            // pnl_foodProperties
            // 
            pnl_foodProperties.BackColor = SystemColors.MenuBar;
            pnl_foodProperties.Controls.Add(label10);
            pnl_foodProperties.Controls.Add(dateTimePicker1);
            pnl_foodProperties.Controls.Add(numericUpDown4);
            pnl_foodProperties.Controls.Add(label9);
            pnl_foodProperties.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            label10.Size = new Size(166, 28);
            label10.TabIndex = 13;
            label10.Text = "Expiring date:*";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(15, 103);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 35);
            dateTimePicker1.TabIndex = 12;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown4.Location = new Point(131, 9);
            numericUpDown4.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(150, 35);
            numericUpDown4.TabIndex = 11;
            numericUpDown4.TextAlign = HorizontalAlignment.Center;
            numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 11);
            label9.Name = "label9";
            label9.Size = new Size(105, 28);
            label9.TabIndex = 10;
            label9.Text = "Weight:*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 191);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 10;
            label5.Text = "Discount:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuBar;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(numericUpDown1);
            panel4.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(28, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 60);
            panel4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 16);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 8;
            label6.Text = "Percentage:*";
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(87, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 32);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Discount";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(424, 13);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(175, 35);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(676, 8);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 3;
            label4.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 98);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 6;
            label2.Text = "Price:*";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuBar;
            panel3.Controls.Add(numericUpDown3);
            panel3.Controls.Add(label7);
            panel3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(676, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 60);
            panel3.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(131, 11);
            numericUpDown3.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(150, 35);
            numericUpDown3.TabIndex = 9;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 13);
            label7.Name = "label7";
            label7.Size = new Size(114, 28);
            label7.TabIndex = 0;
            label7.Text = "In stock:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(352, 8);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 3;
            label3.Text = "Category:*";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(numericUpDown2);
            panel1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(352, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 60);
            panel1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown2.Location = new Point(25, 12);
            numericUpDown2.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(250, 35);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuBar;
            panel2.Controls.Add(comboBox1);
            panel2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(352, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 60);
            panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 36);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 8);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Identifiers:";
            // 
            // pnl_nameBrandInputs
            // 
            pnl_nameBrandInputs.BackColor = SystemColors.MenuBar;
            pnl_nameBrandInputs.Controls.Add(label11);
            pnl_nameBrandInputs.Controls.Add(textBox2);
            pnl_nameBrandInputs.Controls.Add(label8);
            pnl_nameBrandInputs.Controls.Add(textBox1);
            pnl_nameBrandInputs.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            label11.Size = new Size(80, 28);
            label11.TabIndex = 16;
            label11.Text = "Brand:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 35);
            textBox2.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 13);
            label8.Name = "label8";
            label8.Size = new Size(91, 28);
            label8.TabIndex = 14;
            label8.Text = "Name:*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 35);
            textBox1.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1232, 890);
            Controls.Add(pnl_controlsContainer);
            Controls.Add(dtg_adminTable);
            Controls.Add(pnl_title);
            Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = mns_controlsChooser;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            pnl_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_adminTable).EndInit();
            mns_controlsChooser.ResumeLayout(false);
            mns_controlsChooser.PerformLayout();
            pnl_controlsContainer.ResumeLayout(false);
            pnl_controlsContainer.PerformLayout();
            pnl_addControlsContainer.ResumeLayout(false);
            pnl_addControlsContainer.PerformLayout();
            pnl_nonFoodProperties.ResumeLayout(false);
            pnl_nonFoodProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            pnl_foodProperties.ResumeLayout(false);
            pnl_foodProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel2.ResumeLayout(false);
            pnl_nameBrandInputs.ResumeLayout(false);
            pnl_nameBrandInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_title;
        private Label lbl_title;
        private DataGridView dtg_adminTable;
        private MenuStrip mns_controlsChooser;
        private ToolStripMenuItem mni_AddProduct;
        private ToolStripMenuItem editProductToolStripMenuItem;
        private ToolStripMenuItem deleteProductToolStripMenuItem;
        private Panel pnl_controlsContainer;
        private Panel pnl_addControlsContainer;
        private Label label1;
        private Panel pnl_nameBrandInputs;
        private Label label3;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Panel panel3;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private ToolStripMenuItem mni_foodProduct;
        private ToolStripMenuItem mni_nonFoodProduct;
        private ToolStripMenuItem refillStocksToolStripMenuItem;
        private Label lbl_foodProperties;
        private Panel pnl_foodProperties;
        private NumericUpDown numericUpDown4;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label8;
        private Button btn_AddProduct;
        private Label label11;
        private TextBox textBox2;
        private Label lbl_nonFoodProperties;
        private Panel pnl_nonFoodProperties;
        private Label label12;
        private NumericUpDown numericUpDown5;
        private CheckBox checkBox2;
    }
}