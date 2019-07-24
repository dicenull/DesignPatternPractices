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
	public partial class ColleagueCheckBox : CheckBox, IColleague
	{
		private IMediator mediator;

		public ColleagueCheckBox(string caption, bool state)
			: base()
		{
			InitializeComponent();
			Text = caption;
			Checked = state;
		}

		public void SetColleagueEnabled(bool enabled)
		{
			Enabled = enabled;
		}

		public void SetMeiator(IMediator mediator)
		{
			this.mediator = mediator;
		}

		protected override void OnCheckedChanged(EventArgs e)
		{
			mediator.ColleagueChanged();
		}
	}
}
