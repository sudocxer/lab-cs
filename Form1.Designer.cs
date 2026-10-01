namespace lab5_c_
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
            this.buttonEditor = new Button();
            this.buttonTrafficLight = new Button();
            this.buttonExit = new Button();
            this.SuspendLayout();
            //
            // buttonEditor
            //
            this.buttonEditor.Location = new Point(12, 12);
            this.buttonEditor.Name = "buttonEditor";
            this.buttonEditor.Size = new Size(296, 44);
            this.buttonEditor.TabIndex = 0;
            this.buttonEditor.Text = "Графический редактор";
            this.buttonEditor.UseVisualStyleBackColor = true;
            this.buttonEditor.Click += new EventHandler(this.buttonEditor_Click);
            //
            // buttonTrafficLight
            //
            this.buttonTrafficLight.Location = new Point(12, 66);
            this.buttonTrafficLight.Name = "buttonTrafficLight";
            this.buttonTrafficLight.Size = new Size(296, 44);
            this.buttonTrafficLight.TabIndex = 1;
            this.buttonTrafficLight.Text = "Светофор (вариант 4)";
            this.buttonTrafficLight.UseVisualStyleBackColor = true;
            this.buttonTrafficLight.Click += new EventHandler(this.buttonTrafficLight_Click);
            //
            // buttonExit
            //
            this.buttonExit.Location = new Point(12, 120);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(296, 44);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.buttonExit_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(320, 176);
            this.Controls.Add(this.buttonEditor);
            this.Controls.Add(this.buttonTrafficLight);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Графика GDI+";
            this.ResumeLayout(false);
        }

        #endregion

        private Button buttonEditor;
        private Button buttonTrafficLight;
        private Button buttonExit;
    }
}
