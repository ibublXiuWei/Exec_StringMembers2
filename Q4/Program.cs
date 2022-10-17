using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1100225
			string day = "110/02/25";
			string yearplus = day.Substring(0, 3);
			int yyyy=Convert.ToInt32(yearplus)+1911;
			string newday=Convert.ToString(yyyy)+day.Substring(3);
			DateTime answerday=Convert.ToDateTime(newday);
			
			Console.WriteLine(answerday);
		}
	}
}
