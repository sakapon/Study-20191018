using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello GitHub!");
			Console.WriteLine("Hello GitHub!");
			Console.WriteLine("Hello GitHub!");

            int loopCount = 100; // デフォルトの数値
            if (0 < args.Length) loopCount = (int)args[0];
			for (int i = 0; i < loopCount; i++)
			{
				Console.WriteLine("v1.0.0");
			}
		}
	}
}
