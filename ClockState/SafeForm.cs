using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockState
{
	public partial class SafeForm : Form, Context
	{
		State state = DayState.GetInstance();
		int hour = 0;

		public SafeForm()
		{
			InitializeComponent();
		}

		private void ButtonUse_Click(object sender, EventArgs e)
		{
			state.DoUse(this);
		}

		private void ButtonAlarm_Click(object sender, EventArgs e)
		{
			state.DoAlarm(this);
		}

		private void ButtonPhone_Click(object sender, EventArgs e)
		{
			state.DoPhone(this);
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void SetClock(int hour)
		{
			var clockString = "現在時刻は";

			if(hour < 10)
			{
				clockString += $"0{hour}:00";
			}
			else
			{
				clockString += $"{hour}:00";
			}

			Console.WriteLine(clockString);
			label1.Text = clockString;
			state.DoClock(this, hour);
		}

		public void ChangeState(State state)
		{
			Console.WriteLine($"{this.state}から{state}へ状態が変化しました");
			this.state = state;
		}

		public void CallSecurityCenter(string msg)
		{
			textBox1.Text += $"call! {msg}\r\n";
		}

		public void RecordLog(string msg)
		{
			textBox1.Text += $"record ... {msg}\r\n";
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			SetClock(hour);
			hour = (hour + 1) % 24;
		}
	}
}
