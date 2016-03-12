using System;

namespace RandomNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hi! Random number will be generated");
			for (int i = 0; i < 10; i++) {
				RandomNumber ();


			}
		

		}
		public static Random number=new Random();
		public static void RandomNumber(){
			int n = number.Next ();
			Console.WriteLine (n);
			Console.ReadLine ();
		
		}

	}
}
