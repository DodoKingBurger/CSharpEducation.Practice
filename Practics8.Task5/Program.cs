using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics8.Task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var TicTack = new Timer();
			TicTack.TickTimer += SendTime;
			Console.WriteLine($"До конца рабочего дня осталось");
			TicTack.StartTickTack();
		}
		static public void SendTime(DateTime DateTick)
		{
			DateTime todey = DateTime.Today;
			string dateString = $"{todey.Day:D2}/{todey.Month:D2}/{todey.Year} 16:00:00";
			DateTime end = DateTime.ParseExact(dateString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

			TimeSpan result = end - DateTick;
			Console.WriteLine($"Hours: {result.Hours} Minutes: {result.Minutes} Second: {result.Seconds}");
		}
	}
}
