namespace LofinDialogMediator
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.guestRadioButton = new System.Windows.Forms.RadioButton();
			this.loginRadioButton = new System.Windows.Forms.RadioButton();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.userTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// guestRadioButton
			// 
			this.guestRadioButton.AutoSize = true;
			this.guestRadioButton.Location = new System.Drawing.Point(12, 12);
			this.guestRadioButton.Name = "guestRadioButton";
			this.guestRadioButton.Size = new System.Drawing.Size(53, 16);
			this.guestRadioButton.TabIndex = 0;
			this.guestRadioButton.TabStop = true;
			this.guestRadioButton.Text = "Guest";
			this.guestRadioButton.UseVisualStyleBackColor = true;
			this.guestRadioButton.CheckedChanged += new System.EventHandler(this.GuestRadioButton_CheckedChanged);
			// 
			// loginRadioButton
			// 
			this.loginRadioButton.AutoSize = true;
			this.loginRadioButton.Location = new System.Drawing.Point(85, 12);
			this.loginRadioButton.Name = "loginRadioButton";
			this.loginRadioButton.Size = new System.Drawing.Size(50, 16);
			this.loginRadioButton.TabIndex = 1;
			this.loginRadioButton.TabStop = true;
			this.loginRadioButton.Text = "Login";
			this.loginRadioButton.UseVisualStyleBackColor = true;
			this.loginRadioButton.CheckedChanged += new System.EventHandler(this.LoginRadioButton_CheckedChanged);
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 42);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(62, 12);
			this.usernameLabel.TabIndex = 2;
			this.usernameLabel.Text = "Username: ";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(12, 63);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(60, 12);
			this.PasswordLabel.TabIndex = 3;
			this.PasswordLabel.Text = "Password: ";
			// 
			// userTextBox
			// 
			this.userTextBox.Location = new System.Drawing.Point(85, 39);
			this.userTextBox.Name = "userTextBox";
			this.userTextBox.Size = new System.Drawing.Size(100, 19);
			this.userTextBox.TabIndex = 4;
			this.userTextBox.TextChanged += new System.EventHandler(this.UserTextBox_TextChanged);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(85, 63);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(100, 19);
			this.passwordTextBox.TabIndex = 5;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(12, 88);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(96, 23);
			this.okButton.TabIndex = 6;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(114, 88);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(96, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 117);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.userTextBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.loginRadioButton);
			this.Controls.Add(this.guestRadioButton);
			this.Name = "LoginForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton guestRadioButton;
		private System.Windows.Forms.RadioButton loginRadioButton;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox userTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
	}
}