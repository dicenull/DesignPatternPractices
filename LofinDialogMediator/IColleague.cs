using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LofinDialogMediator
{
	public interface IColleague
	{
		void SetMeiator(IMediator mediator);

		void SetColleagueEnabled(bool enabled);
	}
}
