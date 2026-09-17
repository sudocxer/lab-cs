namespace lab2_c_
{
    partial class FormCatalog
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
            this.listBoxProducts = new ListBox();
            this.buttonClose = new Button();
            this.SuspendLayout();
            //
            // listBoxProducts
            //
            this.listBoxProducts.Location = new Point(12, 12);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new Size(300, 184);
            this.listBoxProducts.TabIndex = 0;
            //
            // buttonClose
            //
            this.buttonClose.Location = new Point(12, 205);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(300, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            //
            // FormCatalog
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(324, 252);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCatalog";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Каталог товаров";
            this.Load += new EventHandler(this.FormCatalog_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProducts;
        private Button buttonClose;
    }
}
