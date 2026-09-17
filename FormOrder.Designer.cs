namespace lab2_c_
{
    partial class FormOrder
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
            this.labelProductCaption = new Label();
            this.labelProductNameValue = new Label();
            this.labelQuantity = new Label();
            this.numericUpDownQuantity = new NumericUpDown();
            this.buttonConfirm = new Button();
            this.buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCaption
            //
            this.labelProductCaption.AutoSize = true;
            this.labelProductCaption.Location = new Point(12, 20);
            this.labelProductCaption.Name = "labelProductCaption";
            this.labelProductCaption.Size = new Size(45, 15);
            this.labelProductCaption.TabIndex = 0;
            this.labelProductCaption.Text = "Товар:";
            //
            // labelProductNameValue
            //
            this.labelProductNameValue.AutoSize = true;
            this.labelProductNameValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.labelProductNameValue.Location = new Point(100, 20);
            this.labelProductNameValue.Name = "labelProductNameValue";
            this.labelProductNameValue.Size = new Size(50, 15);
            this.labelProductNameValue.TabIndex = 1;
            this.labelProductNameValue.Text = "-";
            //
            // labelQuantity
            //
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new Point(12, 58);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new Size(78, 15);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Количество:";
            //
            // numericUpDownQuantity
            //
            this.numericUpDownQuantity.Location = new Point(100, 55);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownQuantity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new Size(80, 23);
            this.numericUpDownQuantity.TabIndex = 3;
            //
            // buttonConfirm
            //
            this.buttonConfirm.Location = new Point(12, 95);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new Size(140, 35);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new EventHandler(this.buttonConfirm_Click);
            //
            // buttonCancel
            //
            this.buttonCancel.Location = new Point(158, 95);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(140, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
            //
            // FormOrder
            //
            this.AcceptButton = this.buttonConfirm;
            this.CancelButton = this.buttonCancel;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(310, 145);
            this.Controls.Add(this.labelProductCaption);
            this.Controls.Add(this.labelProductNameValue);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrder";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Оформление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelProductCaption;
        private Label labelProductNameValue;
        private Label labelQuantity;
        private NumericUpDown numericUpDownQuantity;
        private Button buttonConfirm;
        private Button buttonCancel;
    }
}
