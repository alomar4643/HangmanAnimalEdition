using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAnimalEdition
{
	public class Class1
	{

		public string GetChosenWord(string[] listOfWordsAvailable)
		{
            //Random object will generate a random word from the list above
            Random random = new Random();
            var index = random.Next(listOfWordsAvailable.Length);
            string chosenWord = listOfWordsAvailable[index];
          return chosenWord;
        }

		public string[] GetListOfAnimals()
		{
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

			return listOfWordsAvailable;

        }
        public List<int> findIndexes(string chosenWord, char guessLetter)
		{
			List<int> indexes = new List<int>();

			for (int h = 0; h < chosenWord.Length; h++)
			{
				if (guessLetter == chosenWord[h])
				{
					indexes.Add(h);
				}
			}
			return indexes;
		}
	}
}
