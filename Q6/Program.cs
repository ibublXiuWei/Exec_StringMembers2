using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string askname = "Allen";
			
			Console.Write("請輸入Allen,大小寫須一致： ");
			string input = Console.ReadLine();
			string capsname = askname.Substring(0, 1).ToUpper()+askname.Substring(1).ToLower();
			
			if (string.IsNullOrEmpty(input))
			{
				
				Console.WriteLine("您沒有輸入文字");
				return;
			}

			if (input == capsname)
			{
				Console.WriteLine("正確");
			}
			else
			{
				Console.WriteLine("錯誤");
			}
		}
	}
}
