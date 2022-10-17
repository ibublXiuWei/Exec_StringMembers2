using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name2 = "aLLeN kUO";
			string value2=name2.ToLower();
			string print = value2.Substring(0,1).ToUpper() + value2.Substring(1, 5) + value2.Substring(6,1).ToUpper() + value2.Substring(7);
			Console.WriteLine(print);
		}
	}
}
