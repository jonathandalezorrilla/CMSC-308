using System;

namespace Act1
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] username = {"Jonathan", "Dale", "Zorrilla"};
			int[] password = {1234, 5678, 4321};
			string [] email = {"Jonathan@gmail.com", "Dale@gmail.com", "Zorrilla@gmail.com"};
			
			Console.WriteLine("index:");
			string ind;
			ind = Convert.ToString(Console.ReadLine());
			
			if (ind = "1"){
			Console.Write("username:");
			Console.WriteLine(username[0]);
			Console.Write("password:");
			Console.WriteLine(password[0]);
			Console.Write("email:");
			Console.WriteLine(email[0]);
			} else if (ind = "2"){
			Console.Write("username:");
			Console.WriteLine(username[1]);
			Console.Write("password:");
			Console.WriteLine(password[1]);
			Console.Write("email:");
			Console.WriteLine(email[1]);
			} else if (ind = "3"){
			Console.Write("username:");
			Console.WriteLine(username[2]);
			Console.Write("password:");
			Console.WriteLine(password[2]);
			Console.Write("email:");
			Console.WriteLine(email[2]);
			}
			
			Console.ReadLine();
		}
	}
}