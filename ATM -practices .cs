using System;
using System.Collections.Generic;
using System.Linq;
namespace Practice
{
	class MainClass
	{
		public enum Choice
		{
			Balance=1,
			Whithdraw=1,
			Deposit=1

		};
		public static void Main (string[] args)
		{
			Choice choice = Choice.Balance;
			int cHoice = (int)choice;
			int balance=1200, withdraw, deposit;
			int pin = 12;

			Console.WriteLine ("Please enter you pin");
			pin = Convert.ToInt32 (Console.ReadLine ());
			if ( pin ==12){
				while (true) {
					Console.WriteLine ("Welcome to ATM please pick one choice:\n 1 is Balance;\n 2 is Withdraw;\n 3 is Deposit");
					cHoice = Convert.ToInt32 (Console.ReadLine ());
					switch (cHoice) {
					case 1:
						choice = Choice.Balance;
					
						Console.WriteLine ("You chose to check you balance.\n Please press enter to continue");
						Console.WriteLine ("You balance is :" + " " + balance);
						break;
					case 2:
						choice = Choice.Whithdraw;
						Console.WriteLine ("You chose to withdraw");
						Console.ReadLine ();
						Console.WriteLine ("Please enter how much do you want to withdraw from you account");
						withdraw = Convert.ToInt32 (Console.ReadLine ());
						if (withdraw <= balance) {
							Console.WriteLine ("Here is you withdraw"+" "+ withdraw);
							balance = balance - withdraw;
							Console.WriteLine ("You balance is " + " " + balance);
							break;

						} else {

							Console.WriteLine ("You have unsufficient amount");

							break;
						}

					case 3:
						choice = Choice.Whithdraw;
						Console.WriteLine ("You chose to deposit");
						Console.WriteLine ("Please insert cash amount that you want to deposit");
						deposit = Convert.ToInt32 (Console.ReadLine ());
						Console.WriteLine ("You deposit :" + " " + deposit);
						balance = balance + deposit;
						Console.WriteLine ("You total balance:" + " " + balance);
						Console.WriteLine ("Thank you");
						break;
					}
					 
					break;

				}

				Console.WriteLine ("Thank you so much. Have a good day");

			}
			else {
				Console.WriteLine ("You pin is incorrect");
				
				}

			
			Console.ReadLine ();
			}
		}

	}



	
	
		

