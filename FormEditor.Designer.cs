namespace lab5_c_
{
    partial class FormEditor
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
            this.radioButtonLine = new RadioButton();
            this.radioButtonRectangle = new RadioButton();
            this.radioButtonEllipse = new RadioButton();
            this.radioButtonPolygon = new RadioButton();
            this.radioButtonText = new RadioButton();
            this.buttonClear = new Button();
            this.labelWidth = new Label();
            this.numericUpDownWidth = new NumericUpDown();
            this.labelColor = new Label();
            this.swatchBlack = new Button();
            this.swatchRed = new Button();
            this.swatchOrange = new Button();
            this.swatchGold = new Button();
            this.swatchGreen = new Button();
            this.swatchBlue = new Button();
            this.swatchPurple = new Button();
            this.swatchGray = new Button();
            this.buttonMoreColors = new Button();
            this.panelCurrentColor = new Panel();
            this.checkBoxFill = new CheckBox();
            this.labelText = new Label();
            this.textBoxText = new TextBox();
            this.canvas = new DrawingPanel();
            this.labelHint = new Label();
            this.labelCoordinates = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.SuspendLayout();
            //
            // radioButtonLine
            //
            this.radioButtonLine.Appearance = Appearance.Button;
            this.radioButtonLine.Checked = true;
            this.radioButtonLine.Location = new Point(10, 10);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new Size(122, 30);
            this.radioButtonLine.TabIndex = 0;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Линия";
            this.radioButtonLine.TextAlign = ContentAlignment.MiddleCenter;
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new EventHandler(this.tool_CheckedChanged);
            //
            // radioButtonRectangle
            //
            this.radioButtonRectangle.Appearance = Appearance.Button;
            this.radioButtonRectangle.Location = new Point(138, 10);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new Size(122, 30);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.Text = "Прямоугольник";
            this.radioButtonRectangle.TextAlign = ContentAlignment.MiddleCenter;
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new EventHandler(this.tool_CheckedChanged);
            //
            // radioButtonEllipse
            //
            this.radioButtonEllipse.Appearance = Appearance.Button;
            this.radioButtonEllipse.Location = new Point(266, 10);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new Size(122, 30);
            this.radioButtonEllipse.TabIndex = 2;
            this.radioButtonEllipse.Text = "Эллипс";
            this.radioButtonEllipse.TextAlign = ContentAlignment.MiddleCenter;
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new EventHandler(this.tool_CheckedChanged);
            //
            // radioButtonPolygon
            //
            this.radioButtonPolygon.Appearance = Appearance.Button;
            this.radioButtonPolygon.Location = new Point(394, 10);
            this.radioButtonPolygon.Name = "radioButtonPolygon";
            this.radioButtonPolygon.Size = new Size(122, 30);
            this.radioButtonPolygon.TabIndex = 3;
            this.radioButtonPolygon.Text = "Многоугольник";
            this.radioButtonPolygon.TextAlign = ContentAlignment.MiddleCenter;
            this.radioButtonPolygon.UseVisualStyleBackColor = true;
            this.radioButtonPolygon.CheckedChanged += new EventHandler(this.tool_CheckedChanged);
            //
            // radioButtonText
            //
            this.radioButtonText.Appearance = Appearance.Button;
            this.radioButtonText.Location = new Point(522, 10);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new Size(122, 30);
            this.radioButtonText.TabIndex = 4;
            this.radioButtonText.Text = "Текст";
            this.radioButtonText.TextAlign = ContentAlignment.MiddleCenter;
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new EventHandler(this.tool_CheckedChanged);
            //
            // buttonClear
            //
            this.buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.buttonClear.Location = new Point(746, 10);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new Size(104, 30);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new EventHandler(this.buttonClear_Click);
            //
            // labelWidth
            //
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new Point(10, 58);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new Size(58, 15);
            this.labelWidth.TabIndex = 6;
            this.labelWidth.Text = "Толщина:";
            //
            // numericUpDownWidth
            //
            this.numericUpDownWidth.Location = new Point(75, 54);
            this.numericUpDownWidth.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numericUpDownWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new Size(55, 23);
            this.numericUpDownWidth.TabIndex = 7;
            this.numericUpDownWidth.Value = new decimal(new int[] { 3, 0, 0, 0 });
            //
            // labelColor
            //
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new Point(142, 58);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new Size(36, 15);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "Цвет:";
            //
            // swatchBlack
            //
            this.swatchBlack.BackColor = Color.Black;
            this.swatchBlack.Location = new Point(186, 53);
            this.swatchBlack.Name = "swatchBlack";
            this.swatchBlack.Size = new Size(24, 24);
            this.swatchBlack.TabIndex = 9;
            this.swatchBlack.UseVisualStyleBackColor = false;
            this.swatchBlack.Click += new EventHandler(this.swatch_Click);
            //
            // swatchRed
            //
            this.swatchRed.BackColor = Color.Red;
            this.swatchRed.Location = new Point(214, 53);
            this.swatchRed.Name = "swatchRed";
            this.swatchRed.Size = new Size(24, 24);
            this.swatchRed.TabIndex = 10;
            this.swatchRed.UseVisualStyleBackColor = false;
            this.swatchRed.Click += new EventHandler(this.swatch_Click);
            //
            // swatchOrange
            //
            this.swatchOrange.BackColor = Color.Orange;
            this.swatchOrange.Location = new Point(242, 53);
            this.swatchOrange.Name = "swatchOrange";
            this.swatchOrange.Size = new Size(24, 24);
            this.swatchOrange.TabIndex = 11;
            this.swatchOrange.UseVisualStyleBackColor = false;
            this.swatchOrange.Click += new EventHandler(this.swatch_Click);
            //
            // swatchGold
            //
            this.swatchGold.BackColor = Color.Gold;
            this.swatchGold.Location = new Point(270, 53);
            this.swatchGold.Name = "swatchGold";
            this.swatchGold.Size = new Size(24, 24);
            this.swatchGold.TabIndex = 12;
            this.swatchGold.UseVisualStyleBackColor = false;
            this.swatchGold.Click += new EventHandler(this.swatch_Click);
            //
            // swatchGreen
            //
            this.swatchGreen.BackColor = Color.Green;
            this.swatchGreen.Location = new Point(298, 53);
            this.swatchGreen.Name = "swatchGreen";
            this.swatchGreen.Size = new Size(24, 24);
            this.swatchGreen.TabIndex = 13;
            this.swatchGreen.UseVisualStyleBackColor = false;
            this.swatchGreen.Click += new EventHandler(this.swatch_Click);
            //
            // swatchBlue
            //
            this.swatchBlue.BackColor = Color.Blue;
            this.swatchBlue.Location = new Point(326, 53);
            this.swatchBlue.Name = "swatchBlue";
            this.swatchBlue.Size = new Size(24, 24);
            this.swatchBlue.TabIndex = 14;
            this.swatchBlue.UseVisualStyleBackColor = false;
            this.swatchBlue.Click += new EventHandler(this.swatch_Click);
            //
            // swatchPurple
            //
            this.swatchPurple.BackColor = Color.Purple;
            this.swatchPurple.Location = new Point(354, 53);
            this.swatchPurple.Name = "swatchPurple";
            this.swatchPurple.Size = new Size(24, 24);
            this.swatchPurple.TabIndex = 15;
            this.swatchPurple.UseVisualStyleBackColor = false;
            this.swatchPurple.Click += new EventHandler(this.swatch_Click);
            //
            // swatchGray
            //
            this.swatchGray.BackColor = Color.Gray;
            this.swatchGray.Location = new Point(382, 53);
            this.swatchGray.Name = "swatchGray";
            this.swatchGray.Size = new Size(24, 24);
            this.swatchGray.TabIndex = 16;
            this.swatchGray.UseVisualStyleBackColor = false;
            this.swatchGray.Click += new EventHandler(this.swatch_Click);
            //
            // buttonMoreColors
            //
            this.buttonMoreColors.Location = new Point(418, 51);
            this.buttonMoreColors.Name = "buttonMoreColors";
            this.buttonMoreColors.Size = new Size(84, 28);
            this.buttonMoreColors.TabIndex = 17;
            this.buttonMoreColors.Text = "Другой...";
            this.buttonMoreColors.UseVisualStyleBackColor = true;
            this.buttonMoreColors.Click += new EventHandler(this.buttonMoreColors_Click);
            //
            // panelCurrentColor
            //
            this.panelCurrentColor.BackColor = Color.Black;
            this.panelCurrentColor.BorderStyle = BorderStyle.FixedSingle;
            this.panelCurrentColor.Location = new Point(508, 52);
            this.panelCurrentColor.Name = "panelCurrentColor";
            this.panelCurrentColor.Size = new Size(26, 26);
            this.panelCurrentColor.TabIndex = 18;
            //
            // checkBoxFill
            //
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.Location = new Point(550, 56);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new Size(70, 19);
            this.checkBoxFill.TabIndex = 19;
            this.checkBoxFill.Text = "Заливка";
            this.checkBoxFill.UseVisualStyleBackColor = true;
            //
            // labelText
            //
            this.labelText.AutoSize = true;
            this.labelText.Location = new Point(640, 58);
            this.labelText.Name = "labelText";
            this.labelText.Size = new Size(40, 15);
            this.labelText.TabIndex = 20;
            this.labelText.Text = "Текст:";
            //
            // textBoxText
            //
            this.textBoxText.Location = new Point(690, 54);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new Size(160, 23);
            this.textBoxText.TabIndex = 21;
            this.textBoxText.Text = "Текст";
            //
            // canvas
            //
            this.canvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.canvas.BackColor = Color.White;
            this.canvas.BorderStyle = BorderStyle.FixedSingle;
            this.canvas.Location = new Point(10, 92);
            this.canvas.Name = "canvas";
            this.canvas.Size = new Size(840, 452);
            this.canvas.TabIndex = 22;
            this.canvas.Paint += new PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new MouseEventHandler(this.canvas_MouseUp);
            //
            // labelHint
            //
            this.labelHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new Point(10, 553);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new Size(0, 15);
            this.labelHint.TabIndex = 23;
            //
            // labelCoordinates
            //
            this.labelCoordinates.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.labelCoordinates.Location = new Point(730, 553);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new Size(120, 15);
            this.labelCoordinates.TabIndex = 24;
            this.labelCoordinates.Text = "X: 0, Y: 0";
            this.labelCoordinates.TextAlign = ContentAlignment.MiddleRight;
            //
            // FormEditor
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(860, 576);
            this.Controls.Add(this.radioButtonLine);
            this.Controls.Add(this.radioButtonRectangle);
            this.Controls.Add(this.radioButtonEllipse);
            this.Controls.Add(this.radioButtonPolygon);
            this.Controls.Add(this.radioButtonText);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.swatchBlack);
            this.Controls.Add(this.swatchRed);
            this.Controls.Add(this.swatchOrange);
            this.Controls.Add(this.swatchGold);
            this.Controls.Add(this.swatchGreen);
            this.Controls.Add(this.swatchBlue);
            this.Controls.Add(this.swatchPurple);
            this.Controls.Add(this.swatchGray);
            this.Controls.Add(this.buttonMoreColors);
            this.Controls.Add(this.panelCurrentColor);
            this.Controls.Add(this.checkBoxFill);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelCoordinates);
            this.MinimumSize = new Size(880, 480);
            this.Name = "FormEditor";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Графический редактор";
            this.Load += new EventHandler(this.FormEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private RadioButton radioButtonLine;
        private RadioButton radioButtonRectangle;
        private RadioButton radioButtonEllipse;
        private RadioButton radioButtonPolygon;
        private RadioButton radioButtonText;
        private Button buttonClear;
        private Label labelWidth;
        private NumericUpDown numericUpDownWidth;
        private Label labelColor;
        private Button swatchBlack;
        private Button swatchRed;
        private Button swatchOrange;
        private Button swatchGold;
        private Button swatchGreen;
        private Button swatchBlue;
        private Button swatchPurple;
        private Button swatchGray;
        private Button buttonMoreColors;
        private Panel panelCurrentColor;
        private CheckBox checkBoxFill;
        private Label labelText;
        private TextBox textBoxText;
        private DrawingPanel canvas;
        private Label labelHint;
        private Label labelCoordinates;
    }
}
