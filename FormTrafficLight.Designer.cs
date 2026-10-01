namespace lab5_c_
{
    partial class FormTrafficLight
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
            this.components = new System.ComponentModel.Container();
            this.canvas = new DrawingPanel();
            this.labelSignalCaption = new Label();
            this.labelState = new Label();
            this.labelTimer = new Label();
            this.buttonStartStop = new Button();
            this.buttonNext = new Button();
            this.buttonClose = new Button();
            this.timerLight = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            //
            // canvas
            //
            this.canvas.BackColor = Color.White;
            this.canvas.BorderStyle = BorderStyle.FixedSingle;
            this.canvas.Location = new Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new Size(300, 428);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new PaintEventHandler(this.canvas_Paint);
            //
            // labelSignalCaption
            //
            this.labelSignalCaption.AutoSize = true;
            this.labelSignalCaption.Location = new Point(324, 16);
            this.labelSignalCaption.Name = "labelSignalCaption";
            this.labelSignalCaption.Size = new Size(96, 15);
            this.labelSignalCaption.TabIndex = 1;
            this.labelSignalCaption.Text = "Текущий сигнал:";
            //
            // labelState
            //
            this.labelState.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelState.Location = new Point(324, 38);
            this.labelState.Name = "labelState";
            this.labelState.Size = new Size(184, 68);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "Красный — стоп";
            //
            // labelTimer
            //
            this.labelTimer.Location = new Point(324, 110);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new Size(184, 36);
            this.labelTimer.TabIndex = 3;
            this.labelTimer.Text = "Автоматический режим выключен";
            //
            // buttonStartStop
            //
            this.buttonStartStop.Location = new Point(324, 150);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new Size(184, 42);
            this.buttonStartStop.TabIndex = 4;
            this.buttonStartStop.Text = "Старт";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new EventHandler(this.buttonStartStop_Click);
            //
            // buttonNext
            //
            this.buttonNext.Location = new Point(324, 202);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new Size(184, 42);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Переключить сигнал";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new EventHandler(this.buttonNext_Click);
            //
            // buttonClose
            //
            this.buttonClose.Location = new Point(324, 398);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(184, 42);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            //
            // timerLight
            //
            this.timerLight.Interval = 1000;
            this.timerLight.Tick += new EventHandler(this.timerLight_Tick);
            //
            // FormTrafficLight
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(520, 452);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.labelSignalCaption);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTrafficLight";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Светофор";
            this.Load += new EventHandler(this.FormTrafficLight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DrawingPanel canvas;
        private Label labelSignalCaption;
        private Label labelState;
        private Label labelTimer;
        private Button buttonStartStop;
        private Button buttonNext;
        private Button buttonClose;
        private System.Windows.Forms.Timer timerLight;
    }
}
