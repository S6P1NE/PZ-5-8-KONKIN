namespace PZ6
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            productBindingSource = new BindingSource(components);
            categoryBindingSource = new BindingSource(components);
            btnSave = new Button();
            label1 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelProducts.Location = new Point(30, 100);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(956, 333);
            flowLayoutPanelProducts.TabIndex = 0;
            flowLayoutPanelProducts.WrapContents = false;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 476);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "✨ Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 31);
            label1.Name = "label1";
            label1.Size = new Size(283, 26);
            label1.TabIndex = 1;
            label1.Text = "РАБОЧАЯ ЗОНА: ПРОДУКТ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(197, 476);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "➕ Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += this.btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 531);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(flowLayoutPanelProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelProducts;
        private BindingSource productBindingSource;
        private BindingSource categoryBindingSource;
        private Button btnSave;
        private Label label1;
        private Button btnAdd;
    }
}
