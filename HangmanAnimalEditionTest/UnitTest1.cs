using HangmanAnimalEdition;

namespace HangmanAnimalEditionTest
{
    public class Tests
    {

        private Class1 _class1;

        [SetUp]
        public void Setup()
        {
            _class1 = new Class1();
        }

        [Test]
        public void Test_GetListOfWordsAvailable_ReturnsCorrectNumberOfWords()
        {
            var listOfWordsAvailable = _class1.GetListOfAnimals();
            Assert.That(listOfWordsAvailable.Length, Is.EqualTo(11),
                "The GetListOfWordsAvailable method did not return the expected number of words.");
        }

        [Test]
        public void Test_GetChosenWord_ReturnsWordFromParameterList()
        {
            var listOfWordsAvailable = _class1.GetListOfAnimals();
            var chosenWord = _class1.GetChosenWord(listOfWordsAvailable);
            Assert.That(listOfWordsAvailable, Contains.Item(chosenWord));
        }

        [Test]
        public void Test_FindIndexes_ReturnsCorrectIndex()
        {
            var chosenWord = "horse";
            var playersGuess = 's';
            var indexOfPlayerGuess = 3;

            List<int> ints = _class1.findIndexes(chosenWord.ToLower(), playersGuess);

            Assert.That(ints[0], Is.EqualTo(indexOfPlayerGuess));
        }
    }
}