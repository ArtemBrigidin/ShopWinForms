namespace WinFormsApp4
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
            Authorize = new Button();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // Authorize
            // 
            Authorize.Location = new Point(48, 134);
            Authorize.Name = "Authorize";
            Authorize.Size = new Size(296, 30);
            Authorize.TabIndex = 0;
            Authorize.Text = "Авторизоваться";
            Authorize.UseVisualStyleBackColor = true;
            Authorize.Click += Authorize_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(12, 23);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Логин";
            LoginTextBox.Size = new Size(367, 23);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.TextChanged += textBox1_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 88);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Пароль";
            PasswordTextBox.Size = new Size(367, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 193);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(Authorize);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Authorize;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
    }
}