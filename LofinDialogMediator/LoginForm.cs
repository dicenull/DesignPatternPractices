using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LofinDialogMediator
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void controlChanged(object sender, EventArgs e)
		{
			if(guestRadioButton.Checked)
			{
				userTextBox.Enabled = false;
				passwordTextBox.Enabled = false;
				okButton.Enabled = true;
			}
			else
			{
				userTextBox.Enabled = true;
				okButton.Enabled = false;
				userPassChanged();
			}
		}

		private void userPassChanged()
		{
			if(userTextBox.TextLength >= 4)
			{
				passwordTextBox.Enabled = true;

				bool checkOk = (passwordTextBox.TextLength >= 4);
				okButton.Enabled = checkOk;
			}
		}

		private void GuestRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			controlChanged(sender, e);
		}

		private void LoginRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			controlChanged(sender, e);
		}

		private void UserTextBox_TextChanged(object sender, EventArgs e)
		{
			controlChanged(sender, e);
		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			controlChanged(sender, e);
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			controlChanged(sender, e);
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			controlChanged(sender, e);
		}
	}
}
