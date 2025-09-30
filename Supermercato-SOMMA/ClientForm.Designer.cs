namespace Supermercato_SOMMA.Managers
{
    partial class ClientForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_adminDashboard = new Button();
            label1 = new Label();
            dtg_clientTable = new DataGridView();
            pnl_container = new Panel();
            panel4 = new Panel();
            btn_pay = new Button();
            label5 = new Label();
            lbl_totalPrice = new Label();
            btn_addProduct = new Button();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            nmr_productQuantity = new NumericUpDown();
            label3 = new Label();
            panel2 = new Panel();
            cmb_selectedProduct = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_clientTable).BeginInit();
            pnl_container.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_productQuantity).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_adminDashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 5, 6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1232, 150);
            panel1.TabIndex = 0;
            // 
            // btn_adminDashboard
            // 
            btn_adminDashboard.Location = new Point(1042, 0);
            btn_adminDashboard.Name = "btn_adminDashboard";
            btn_adminDashboard.Size = new Size(190, 48);
            btn_adminDashboard.TabIndex = 1;
            btn_adminDashboard.Text = "Admin";
            btn_adminDashboard.UseVisualStyleBackColor = true;
            btn_adminDashboard.Click += btn_adminDashboard_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1232, 150);
            label1.TabIndex = 0;
            label1.Text = "Supermarket";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtg_clientTable
            // 
            dtg_clientTable.AllowUserToAddRows = false;
            dtg_clientTable.AllowUserToDeleteRows = false;
            dtg_clientTable.AllowUserToResizeColumns = false;
            dtg_clientTable.AllowUserToResizeRows = false;
            dtg_clientTable.BackgroundColor = SystemColors.Window;
            dtg_clientTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_clientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_clientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_clientTable.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_clientTable.Dock = DockStyle.Left;
            dtg_clientTable.GridColor = SystemColors.ControlDarkDark;
            dtg_clientTable.Location = new Point(0, 150);
            dtg_clientTable.MultiSelect = false;
            dtg_clientTable.Name = "dtg_clientTable";
            dtg_clientTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtg_clientTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtg_clientTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtg_clientTable.ScrollBars = ScrollBars.Vertical;
            dtg_clientTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_clientTable.Size = new Size(900, 740);
            dtg_clientTable.TabIndex = 2;
            // 
            // pnl_container
            // 
            pnl_container.BackColor = Color.White;
            pnl_container.Controls.Add(panel4);
            pnl_container.Controls.Add(btn_addProduct);
            pnl_container.Controls.Add(label4);
            pnl_container.Controls.Add(label2);
            pnl_container.Controls.Add(panel3);
            pnl_container.Controls.Add(label3);
            pnl_container.Controls.Add(panel2);
            pnl_container.Dock = DockStyle.Right;
            pnl_container.Location = new Point(897, 150);
            pnl_container.Name = "pnl_container";
            pnl_container.Size = new Size(335, 740);
            pnl_container.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuBar;
            panel4.Controls.Add(btn_pay);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lbl_totalPrice);
            panel4.Font = new Font("Tahoma", 13.8F);
            panel4.Location = new Point(0, 539);
            panel4.Name = "panel4";
            panel4.Size = new Size(335, 200);
            panel4.TabIndex = 9;
            // 
            // btn_pay
            // 
            btn_pay.Location = new Point(17, 124);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(300, 65);
            btn_pay.TabIndex = 2;
            btn_pay.Text = "Pay";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += this.btn_pay_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 20);
            label5.Name = "label5";
            label5.Size = new Size(42, 48);
            label5.TabIndex = 1;
            label5.Text = "€";
            // 
            // lbl_totalPrice
            // 
            lbl_totalPrice.AutoSize = true;
            lbl_totalPrice.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_totalPrice.Location = new Point(65, 20);
            lbl_totalPrice.Name = "lbl_totalPrice";
            lbl_totalPrice.Size = new Size(98, 48);
            lbl_totalPrice.TabIndex = 0;
            lbl_totalPrice.Text = "0.00";
            // 
            // btn_addProduct
            // 
            btn_addProduct.Location = new Point(17, 316);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(300, 68);
            btn_addProduct.TabIndex = 10;
            btn_addProduct.Text = "Add";
            btn_addProduct.UseVisualStyleBackColor = true;
            btn_addProduct.Click += btn_addProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 25);
            label4.Name = "label4";
            label4.Size = new Size(106, 34);
            label4.TabIndex = 9;
            label4.Text = "Order:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Italic);
            label2.Location = new Point(17, 187);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 8;
            label2.Text = "Quantity:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuBar;
            panel3.Controls.Add(nmr_productQuantity);
            panel3.Font = new Font("Tahoma", 13.8F);
            panel3.Location = new Point(17, 211);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 60);
            panel3.TabIndex = 7;
            // 
            // nmr_productQuantity
            // 
            nmr_productQuantity.Location = new Point(25, 12);
            nmr_productQuantity.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nmr_productQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_productQuantity.Name = "nmr_productQuantity";
            nmr_productQuantity.Size = new Size(250, 35);
            nmr_productQuantity.TabIndex = 8;
            nmr_productQuantity.TextAlign = HorizontalAlignment.Center;
            nmr_productQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Italic);
            label3.Location = new Point(17, 80);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 5;
            label3.Text = "Select product:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuBar;
            panel2.Controls.Add(cmb_selectedProduct);
            panel2.Font = new Font("Tahoma", 13.8F);
            panel2.Location = new Point(17, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 60);
            panel2.TabIndex = 4;
            // 
            // cmb_selectedProduct
            // 
            cmb_selectedProduct.FormattingEnabled = true;
            cmb_selectedProduct.Location = new Point(25, 10);
            cmb_selectedProduct.Name = "cmb_selectedProduct";
            cmb_selectedProduct.Size = new Size(250, 36);
            cmb_selectedProduct.TabIndex = 4;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 890);
            Controls.Add(pnl_container);
            Controls.Add(dtg_clientTable);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClientForm";
            Text = "Client";
            Load += ClientForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_clientTable).EndInit();
            pnl_container.ResumeLayout(false);
            pnl_container.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmr_productQuantity).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dtg_clientTable;
        private Panel pnl_container;
        private Label label3;
        private Panel panel2;
        private ComboBox cmb_selectedProduct;
        private Label label2;
        private Panel panel3;
        private NumericUpDown nmr_productQuantity;
        private Panel panel4;
        private Label lbl_totalPrice;
        private Button btn_addProduct;
        private Label label4;
        private Button btn_pay;
        private Label label5;
        private Button btn_adminDashboard;
    }
}