namespace PZ6
{
    partial class ProductCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pbPhoto = new PictureBox();
            btnEdit = new Button();
            btnDelete = new Button();
            lblName = new Label();
            lblPrice = new Label();
            lblArt = new Label();
            lblCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            SuspendLayout();
            // 
            // pbPhoto
            // 
            pbPhoto.Location = new Point(37, 40);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(234, 239);
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.TabIndex = 0;
            pbPhoto.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(709, 47);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(170, 33);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "🖍️ Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(709, 101);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 31);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "🗑️ Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(327, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 8;
            lblName.Text = "label5";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(327, 101);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "label6";
            // 
            // lblArt
            // 
            lblArt.AutoSize = true;
            lblArt.Location = new Point(327, 153);
            lblArt.Name = "lblArt";
            lblArt.Size = new Size(38, 15);
            lblArt.TabIndex = 10;
            lblArt.Text = "label7";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(327, 204);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(38, 15);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "label8";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCategory);
            Controls.Add(lblArt);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(pbPhoto);
            Name = "ProductCard";
            Size = new Size(914, 311);
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPhoto;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblName;
        private Label lblPrice;
        private Label lblArt;
        private Label lblCategory;
    }
}
