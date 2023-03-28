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
			Console.WriteLine("Press ~ to exit\n");
			Console.WriteLine("Welcome to Hangman!- Animal Edition");
			Console.WriteLine("------------------------\n");
			Console.WriteLine("Enter your first guess; Hint: All words have 5 letters");

			string[] listOfWordsAvailable = new string[11];

			listOfWordsAvailable[0] = "horse";
			listOfWordsAvailable[1] = "koala";
			listOfWordsAvailable[2] = "moose";
			listOfWordsAvailable[3] = "camel";
			listOfWordsAvailable[4] = "mouse";
			listOfWordsAvailable[5] = "snake";
			listOfWordsAvailable[6] = "sheep";
			listOfWordsAvailable[7] = "skunk";
			listOfWordsAvailable[8] = "snail";
			listOfWordsAvailable[9] = "whale";
			listOfWordsAvailable[10] = "zebra";

			Class1 class1 = new Class1();

			//Random object will generate a random word from the list above
			Random random = new Random();
			var index = random.Next(listOfWordsAvailable.Length);
			var lives = 6;
			string chosenWord = listOfWordsAvailable[index];
			char[] guess = new char[chosenWord.Length];

			//i++ increments the variable by 1
			for (int i = 0; i < chosenWord.Length; i++)

				//char guess displays the number of letters in the words of the list of words available. This is represented by the symbol '*'
				guess[i] = '*';

			while (true)
			{
				try
				{
					//converts value of string into a char
					char playersGuess = char.Parse(Console.ReadLine());

					if (chosenWord.ToLower().IndexOf(playersGuess) != -1)
					{
						Console.WriteLine("Correct guess, Keep going!");

						List<int> ints = class1.findIndexes(chosenWord.ToLower(), playersGuess);

						for (int j = 0; j < ints.Count; j++)
						{
							guess[ints[j]] = playersGuess;
						}
						if (Array.IndexOf(guess, '*') == -1)
						{
							Console.WriteLine("-----------------------\n");
							Console.WriteLine("Congrats you won!");
							break;
						}
					}
					else
					{
						lives--;//lives = lives minus 1
						Console.WriteLine("Incorrect guess, try another! " + "You have: " + lives + " lives left");

						if (lives == 0)
						{
							Console.WriteLine("-----------------------\n");
							Console.WriteLine("Sorry you Lost!");
							break;
						}
					}
					if (playersGuess == '~')
					{
						break;
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Please enter a single letter guess");
				}
				Console.WriteLine(guess);
			}
		}
	}
}

