using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string askname = "Allen";
			Console.Write("請輸入Allen,大小寫不拘： ");
			string input=Console.ReadLine();

			if(string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入文字");
				return;
			}
			if(input.ToLower()==askname.ToLower())
			{
				Console.WriteLine("正確");
			}else
			{
				Console.WriteLine("錯誤");
			}
		}
	}
}
