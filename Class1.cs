using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAnimalEdition
{
	public class Class1
	{
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
