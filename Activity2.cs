using System;

namespace Activity2
{
	class Program
	{
		public static void Main(string[] args)
			{
        	int[] arr1 = new int[5] {
            3,
            6,
            9,
            12,
            15
         };
			Console.WriteLine("Array program");
			Console.WriteLine(arr1[0]);
			Console.WriteLine(arr1[1]);
			Console.WriteLine(arr1[2]);
			Console.WriteLine(arr1[3]);
			Console.WriteLine(arr1[4]);
			Console.WriteLine();
         	int[] arr2 = new int[5];
         	int[] arr3 = new int[5];
         	int i, j = 0, k = 0;
         	for (i = 0; i < 5; i++) {
            	if (arr1[i] % 2 == 0) {
               		arr2[j] = arr1[i];
               		j++;
            		}
         		else {
               		arr3[k] = arr1[i];
               		k++;
            		}
        	 	}
         	Console.WriteLine("Even numbers: ");
         	for (i = 0; i < j; i++) {
            	Console.WriteLine(arr2[i]);
         	}
         	Console.WriteLine();
         	Console.WriteLine("Odd numbers: ");
         	for (i = 0; i < k; i++) {
            	Console.WriteLine(arr3[i]);
         	}
               Console.ReadLine();
		}
	}
}
