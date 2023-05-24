namespace WordLib
{
    public class Word
    {
        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException("Word cannot be empty or null.");
            }


            //char[] charArray = word.ToCharArray();// Reverse the word
            //Array.Reverse(charArray);
            //string reversedWord = new string(charArray);
           
            string reversedWord = new string(word.Reverse().ToArray());// using LINQ's Reverse() method to reverse characters


            return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);  // Compare the reversed word with the original word using 'string.Equals()
        }
        public int CountLetters(string word)
        {
            
            if (string.IsNullOrEmpty(word))  // Check if the word is empty or null
            {
                throw new ArgumentException("Word cannot be empty or null.");
            }

            return word.Length;
        }

    }
}