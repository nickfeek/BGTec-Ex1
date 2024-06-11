using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary.Tests
{
    [TestClass]
    public class Ex1ClassTests
    {

        [TestMethod]
        public void IsPalindrome_ReturnsTrueForValidPalindromeWithOddNumberOfCharacters()
        {
            string testString = "never odd or even.";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueForValidPalindromeWithEvenNumberOfCharacters()
        {
            string testString = "dammit, I'm mad.";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueWithAsymetricalSpaces()
        {
            string testString = "never odd or  even";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueWithSpecialCharacters()
        {
            string testString = "never odd or ~ ` ! @ # $ % ^ & * ( ) - _ + = {{ }} [ ] | \\ / : ; \" ' < > , . ? even";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueWithLeadingAndTrailingSpaces()
        {
            string testString = "  never odd or even ";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueWithMixedCase()
        {
            string testString = "Never odD or eVen";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueWithSingleCharacter()
        {
            string testString = "X";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueWithForeignCharacters()
        {
            string testString = "névén";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsFalseWithForeignCharacterMismatch()
        {
            string testString = "néven";
            bool result = Ex1Class.IsPalindrome(testString);
            Assert.IsFalse(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrueForVariousValidPalindromes()
        {
            string[] testStrings = {
                "A man, a plan, a canal: Panama.",
                "Nurse, I spy gypsies, run!",
                "A Toyota. Race fast, safe car. A Toyota.",
                "Cigar? Toss it in a can. It is so tragic.",
                "Dammit, I'm mad!",
                "Delia saw I was ailed.",
                "Desserts, I stressed!",
                "Draw, O coward!",
                "Lepers repel.",
                "Live not on evil.",
                "Lonely Tylenol.",
                "Murder for a jar of red rum.",
                "Never odd or even.",
                "No lemon, no melon.",
                "Senile felines.",
                "So many dynamos!",
                "Step on no pets.",
                "Was it a car or a cat I saw?",};

            foreach (var testString in testStrings)
            {
                bool result = Ex1Class.IsPalindrome(testString);
                Assert.IsTrue(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
            }
        }

        [TestMethod]
        public void IsNotPalindrome_ReturnsFalseForVariousInvalidPalindromes()
        {
            string[] testStrings = {
                "A man, a plan, a caxnal: Panama.",
                "Nurse, I spy gypsies, run!x",
                "A Toyota. Race fasxt, safe car. A Toyota.",
                "Cigar? Toss it in ax can. It is so tragic.",
                "Dammit, xI'm mad!",
                "Delia sawx I was ailed.",
                "Desserts, xI stressed!",
                "Draw, O xcoward!",
                "Lepers rxepel.",
                "Live not xon evil.",
                "Lonely xTylenol.",
                "Murder fxor a jar of red rum.",
                "Never oddx or even.",
                "No lemon, no xmelon.",
                "Senile fexlines.",
                "So many xdynamos!",
                "Sxtep on no pets.",
                "Was it a cxar or a cat I saw?",};

            foreach (var testString in testStrings)
            {
                bool result = Ex1Class.IsPalindrome(testString);
                Assert.IsFalse(result, string.Format($"Expected for '{testString}': true; Actual: {result}"));
            }
        
        }

        [TestMethod]
        public void IsPalindrome_ThrowsExceptionWithNull()
        {
            #nullable disable
            var e = Assert.ThrowsException<ArgumentException>(() => Ex1Class.IsPalindrome(null));
            #nullable restore
            Assert.AreEqual("Input cannot be null or empty (Parameter 'input')", e.Message);
        }

        [TestMethod]
        public void IsPalindrome_ThrowsExceptionWithEmpty()
        {
            #nullable disable
            var e = Assert.ThrowsException<ArgumentException>(() => Ex1Class.IsPalindrome(""));
            #nullable restore
            Assert.AreEqual("Input cannot be null or empty (Parameter 'input')", e.Message);
        }

    }
}
