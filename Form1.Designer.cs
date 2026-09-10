namespace lab1_c_
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
            this.labelLogin = new Label();
            this.textBoxLogin = new TextBox();
            this.labelPassword = new Label();
            this.textBoxPassword = new TextBox();
            this.labelEmail = new Label();
            this.textBoxEmail = new TextBox();
            this.labelPhone = new Label();
            this.textBoxPhone = new TextBox();
            this.buttonRegister = new Button();
            this.buttonClear = new Button();
            this.buttonExit = new Button();
            this.SuspendLayout();
            //
            // labelLogin
            //
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new Point(12, 20);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new Size(45, 15);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            //
            // textBoxLogin
            //
            this.textBoxLogin.Location = new Point(140, 17);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new Size(220, 23);
            this.textBoxLogin.TabIndex = 1;
            //
            // labelPassword
            //
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new Point(12, 55);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new Size(50, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль:";
            //
            // textBoxPassword
            //
            this.textBoxPassword.Location = new Point(140, 52);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new Size(220, 23);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            //
            // labelEmail
            //
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(12, 90);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(42, 15);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            //
            // textBoxEmail
            //
            this.textBoxEmail.Location = new Point(140, 87);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new Size(220, 23);
            this.textBoxEmail.TabIndex = 5;
            //
            // labelPhone
            //
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(12, 125);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(59, 15);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Телефон:";
            //
            // textBoxPhone
            //
            this.textBoxPhone.Location = new Point(140, 122);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new Size(220, 23);
            this.textBoxPhone.TabIndex = 7;
            //
            // buttonRegister
            //
            this.buttonRegister.Location = new Point(12, 170);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new Size(150, 35);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Зарегистрировать";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new EventHandler(this.buttonRegister_Click);
            //
            // buttonClear
            //
            this.buttonClear.Location = new Point(172, 170);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new Size(90, 35);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new EventHandler(this.buttonClear_Click);
            //
            // buttonExit
            //
            this.buttonExit.Location = new Point(272, 170);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(90, 35);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.buttonExit_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(384, 231);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя";
            this.Load += new EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox textBoxLogin;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Button buttonRegister;
        private Button buttonClear;
        private Button buttonExit;
    }
}
