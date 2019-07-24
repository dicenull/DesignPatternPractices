using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LofinDialogMediator
{
	public partial class ColleagueTextField : TextBox, IColleague
	{
		private IMediator mediator;

		public ColleagueTextField(string text)
			: base()
		{
			InitializeComponent();
			Text = text;
		}

		public void SetColleagueEnabled(bool enabled)
		{
			Enabled = enabled;
		}

		public void SetMeiator(IMediator mediator)
		{
			this.mediator = mediator;
		}

		protected override void OnTextChanged(EventArgs e)
		{
			mediator.ColleagueChanged();
		}
	}
}
