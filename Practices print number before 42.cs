using System;

namespace Numbers
{
	
		class MainClass
		{
			public static void Main (string[] args)
			{

				int m;
				Console.WriteLine ("Please enter the size of list");
				try{
					m = Convert.ToInt32 (Console.ReadLine ());
					int[] a = new int[m];



					Console.WriteLine ("Please enter the number into your list");

					for (int i = 0; i < m; i++) {

						a [i] = Convert.ToInt32 (Console.ReadLine ());

					}

					foreach (int o in a) {
						if (o == 42) {
							break;


						}

						Console.Write ("\n");

						Console.WriteLine (o);}

				}


				catch(FormatException ex)

				{

					Console.WriteLine ("Please enter the number");
				}



				Console.ReadLine ();
			}
		}

	}
	

