using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string phone = "0935121246";
			Console.Write("請輸入手機號碼： ");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入號碼！");
				return;
			}
			if (input.Length != 10)
			{
				Console.WriteLine("輸入號碼錯誤");
				return;
			}


			string secretnumber = input.Substring(0, 4) + new string('*', 4) + input.Substring(7);
			Console.WriteLine(secretnumber);

		}
	}
}
