using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAnimalEdition
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Hangman!- Animal Edition");
			Console.WriteLine("------------------------\n");
			Console.WriteLine("Enter your first guess");

			string[] listOfWordsAvailable = new string[5];

			listOfWordsAvailable[0] = "horse";
			listOfWordsAvailable[1] = "koala";
			listOfWordsAvailable[2] = "moose";
			listOfWordsAvailable[3] = "camel";
			listOfWordsAvailable[4] = "mouse";

			Class1 class1 = new Class1();
		}
	}
}