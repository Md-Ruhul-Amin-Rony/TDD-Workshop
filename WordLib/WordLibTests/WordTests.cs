using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class WordTests
    {
        [TestMethod]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            string word = "radar";
            bool wish = true;
            Word wordNew = new Word();

            // Act
            bool actual = wordNew.IsPalindrome(word);

            // Assert
            Assert.AreEqual(wish, actual);
        }
        [TestMethod]
        public void CountLetters_ValidWord_ReturnsCorrectCount()
        {
            // Arrange
            string word = "hello";
            int wordCount = 5;
            Word wordObj = new Word();

            // Act
            int actualCount = wordObj.CountLetters(word);

            // Assert
            Assert.AreEqual(wordCount, actualCount);
        }

        [TestMethod]
        public void CountLetters_EmptyWord_ThrowsArgumentException()
        {
            // Arrange
            string word = "";
            Word wordNew = new Word();

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => wordNew.CountLetters(word));
        }

        [TestMethod]
        public void CountLetters_NullWord_ThrowsArgumentException()
        {
            // Arrange
            string word = null;
            Word wordObj = new Word();

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => wordObj.CountLetters(word));
        }
    }
}