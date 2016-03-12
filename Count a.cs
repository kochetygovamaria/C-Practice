using System;

namespace HowOften
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please any phrase");
			string input = Console.ReadLine ();
			int count=0;

			foreach (char item in input) {


				if (item == 'a') {
					count++;
				}
			
			
			}

			Console.WriteLine (count);
			Console.ReadLine ();
		}
	}

	}

