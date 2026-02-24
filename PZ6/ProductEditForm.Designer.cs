namespace PZ6
{
    partial class ProductEditForm
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
            components = new System.ComponentModel.Container();
            txtArticle = new TextBox();
            editProductBindingSource = new BindingSource(components);
            txtName = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            editCategoryBindingSource = new BindingSource(components);
            cmbProductName = new ComboBox();
            editProductNameBindingSource = new BindingSource(components);
            cmbManufacturer = new ComboBox();
            editManufacturerBindingSource = new BindingSource(components);
            cmbSupplier = new ComboBox();
            editSupplierBindingSource = new BindingSource(components);
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)editProductBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editCategoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editProductNameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editManufacturerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editSupplierBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtArticle
            // 
            txtArticle.DataBindings.Add(new Binding("Text", editProductBindingSource, "Article", true, DataSourceUpdateMode.OnPropertyChanged));
            txtArticle.Location = new Point(158, 50);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(159, 23);
            txtArticle.TabIndex = 0;
            // 
            // editProductBindingSource
            // 
            editProductBindingSource.DataSource = typeof(Models.Product);
            // 
            // txtName
            // 
            txtName.DataBindings.Add(new Binding("Text", editProductBindingSource, "IdProductNameNavigation.ProductName1", true, DataSourceUpdateMode.OnPropertyChanged));
            txtName.Location = new Point(158, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(159, 23);
            txtName.TabIndex = 1;
            txtName.Visible = false;
            // 
            // txtPrice
            // 
            txtPrice.DataBindings.Add(new Binding("Text", editProductBindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            txtPrice.Location = new Point(158, 102);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(159, 23);
            txtPrice.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.DataBindings.Add(new Binding("SelectedValue", editProductBindingSource, "IdCategory", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(158, 162);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(159, 23);
            cmbCategory.TabIndex = 3;
            // 
            // editCategoryBindingSource
            // 
            editCategoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // cmbProductName
            // 
            cmbProductName.DataBindings.Add(new Binding("SelectedValue", editProductBindingSource, "IdProductName", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductName.FormattingEnabled = true;
            cmbProductName.Location = new Point(158, 221);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.Size = new Size(159, 23);
            cmbProductName.TabIndex = 11;
            // 
            // editProductNameBindingSource
            // 
            editProductNameBindingSource.DataSource = typeof(Models.ProductName);
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.DataBindings.Add(new Binding("SelectedValue", editProductBindingSource, "IdManufacturer", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(158, 280);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(159, 23);
            cmbManufacturer.TabIndex = 12;
            // 
            // editManufacturerBindingSource
            // 
            editManufacturerBindingSource.DataSource = typeof(Models.Manufacturer);
            // 
            // cmbSupplier
            // 
            cmbSupplier.DataBindings.Add(new Binding("SelectedValue", editProductBindingSource, "IdSupplier", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(158, 339);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(159, 23);
            cmbSupplier.TabIndex = 13;
            // 
            // editSupplierBindingSource
            // 
            editSupplierBindingSource.DataSource = typeof(Models.Supplier);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 462);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 42);
            btnSave.TabIndex = 4;
            btnSave.Text = "✅ Применить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(230, 462);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "❌ Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = " Артикул: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Цена:  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 9;
            label4.Text = "Категория:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 9);
            label5.Name = "label5";
            label5.Size = new Size(219, 19);
            label5.TabIndex = 10;
            label5.Text = "РЕДАКТИРОВАНИЕ ТОВАРА";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 221);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 14;
            label6.Text = "Название товара:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 280);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 15;
            label7.Text = "Производитель:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 339);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 16;
            label8.Text = "Поставщик:";
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 520);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbManufacturer);
            Controls.Add(cmbProductName);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtArticle);
            Controls.Add(txtName);
            Name = "ProductEditForm";
            Text = "ProductEditForm";
            ((System.ComponentModel.ISupportInitialize)editProductBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)editCategoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)editProductNameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)editManufacturerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)editSupplierBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArticle;
        private TextBox txtName;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private ComboBox cmbProductName;
        private ComboBox cmbManufacturer;
        private ComboBox cmbSupplier;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public BindingSource editProductBindingSource;
        public BindingSource editCategoryBindingSource;
        public BindingSource editProductNameBindingSource;
        public BindingSource editManufacturerBindingSource;
        public BindingSource editSupplierBindingSource;
    }
}