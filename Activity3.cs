using System;

namespace Zorrilla
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Above 100        -Invalid Grade");
			Console.WriteLine("Above 98-100     -With Highest Honor");
			Console.WriteLine("Above 95-97.99   -With High Honor");
			Console.WriteLine("Above 90- 94.99  -With Honor");
			Console.WriteLine("Above 79-89.99   -Passed");
			Console.WriteLine("Below            -Failed");
			Console.WriteLine("------------------------------------");
			Console.Write("English: ");
			int eng = Convert.ToInt32(Console.ReadLine());
			Console.Write("Science: ");
			int sci = Convert.ToInt32(Console.ReadLine());
			Console.Write("Math:    ");
			int mat = Convert.ToInt32(Console.ReadLine());
			Console.Write("MAPEH:   ");
			int map = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			int ave = (eng + sci + mat + map) / 4;
			Console.Write("Average: ");
			Console.WriteLine(ave);
			int average = ave;
			if(average >= 100){
				Console.WriteLine("Invalid Grade");
			}else if(average >= 98){
				Console.WriteLine("With Highest Honor");
			}
			else if(average >= 95){
				Console.WriteLine("With High Honor");
			}
			else if(average >= 90){
				Console.WriteLine("With Honor");
			}
			else if(average >= 80){
				Console.WriteLine("Passed");
			}
			else if(average >= 0){
				Console.WriteLine("Failed");
			}
			Console.WriteLine("------------------------------------");
			Console.ReadLine();
		}
	}
}
