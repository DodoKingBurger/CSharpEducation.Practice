using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practics8.Task5
{
	public class Timer
	{
		public delegate void Tick(DateTime time);
		public event Tick TickTimer;
		DateTime DateTime {  get; set; }
		public void StartTickTack()
		{			
			DateTime time;
			while (true)
			{
				time = DateTime.Now;
				if(time.Second == (DateTime.Second + 1))
				{
					DateTime = time;
					this.TickTimer?.Invoke(this.DateTime);
				}
				else if(time.Second == 0)
				{					
					Thread.Sleep(1000);
					DateTime = time;
					this.TickTimer?.Invoke(this.DateTime);
				}
			}
		}
		public Timer() 
		{
			DateTime = DateTime.Now;
		}
	}
}
