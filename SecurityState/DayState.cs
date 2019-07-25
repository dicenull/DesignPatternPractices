using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityState
{
	public class DayState : State
	{
		private static DayState singleton = new DayState();

		private DayState() { }

		public static State GetInstance()
		{
			return singleton;
		}

		public void DoAlarm(Context context)
		{
			context.CallSecurityCenter("非常ベル(Day)");
		}

		public void DoClock(Context context, int hour)
		{
			if(hour < 9 || 17 <= hour)
			{
				context.ChangeState(NightState.GetInstance());
			}
		}

		public void DoPhone(Context context)
		{
			context.CallSecurityCenter("通常電話(Day)");
		}

		public void DoUse(Context context)
		{
			context.RecordLog("金庫使用(Day)");
		}
	}
}
