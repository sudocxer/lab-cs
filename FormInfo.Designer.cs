namespace lab4_c_
{
    partial class FormInfo
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
            this.labelInfo = new Label();
            this.buttonClose = new Button();
            this.SuspendLayout();
            //
            // labelInfo
            //
            this.labelInfo.Location = new Point(12, 12);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new Size(280, 120);
            this.labelInfo.TabIndex = 0;
            //
            // buttonClose
            //
            this.buttonClose.Location = new Point(12, 140);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(280, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            //
            // FormInfo
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(304, 187);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInfo";
            this.Text = "Информация";
            this.Load += new EventHandler(this.FormInfo_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private Label labelInfo;
        private Button buttonClose;
    }
}
