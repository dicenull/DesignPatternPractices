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
	public partial class ColleagueButton : Button, IColleague
	{
		private IMediator mediator;

		public ColleagueButton(string caption)
			: base()
		{
			Text = caption;
		}

		public void SetColleagueEnabled(bool enabled)
		{
			Enabled = enabled;
		}

		public void SetMeiator(IMediator mediator)
		{
			this.mediator = mediator;
		}
	}
}
