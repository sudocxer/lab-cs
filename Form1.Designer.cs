namespace lab2_c_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelProduct = new Label();
            this.textBoxProductName = new TextBox();
            this.buttonCatalog = new Button();
            this.buttonOrder = new Button();
            this.buttonContacts = new Button();
            this.buttonAbout = new Button();
            this.buttonExit = new Button();
            this.SuspendLayout();
            //
            // labelProduct
            //
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new Point(12, 20);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new Size(45, 15);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Товар:";
            //
            // textBoxProductName
            //
            this.textBoxProductName.Location = new Point(100, 17);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new Size(248, 23);
            this.textBoxProductName.TabIndex = 1;
            //
            // buttonCatalog
            //
            this.buttonCatalog.Location = new Point(12, 60);
            this.buttonCatalog.Name = "buttonCatalog";
            this.buttonCatalog.Size = new Size(160, 35);
            this.buttonCatalog.TabIndex = 2;
            this.buttonCatalog.Text = "Каталог товаров";
            this.buttonCatalog.UseVisualStyleBackColor = true;
            this.buttonCatalog.Click += new EventHandler(this.buttonCatalog_Click);
            //
            // buttonOrder
            //
            this.buttonOrder.Location = new Point(188, 60);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new Size(160, 35);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "Оформить заказ";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new EventHandler(this.buttonOrder_Click);
            //
            // buttonContacts
            //
            this.buttonContacts.Location = new Point(12, 105);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new Size(160, 35);
            this.buttonContacts.TabIndex = 4;
            this.buttonContacts.Text = "Контакты";
            this.buttonContacts.UseVisualStyleBackColor = true;
            this.buttonContacts.Click += new EventHandler(this.buttonContacts_Click);
            //
            // buttonAbout
            //
            this.buttonAbout.Location = new Point(188, 105);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new Size(160, 35);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "О программе";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new EventHandler(this.buttonAbout_Click);
            //
            // buttonExit
            //
            this.buttonExit.Location = new Point(12, 150);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(336, 35);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.buttonExit_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 205);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.buttonCatalog);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonContacts);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelProduct;
        private TextBox textBoxProductName;
        private Button buttonCatalog;
        private Button buttonOrder;
        private Button buttonContacts;
        private Button buttonAbout;
        private Button buttonExit;
    }
}
