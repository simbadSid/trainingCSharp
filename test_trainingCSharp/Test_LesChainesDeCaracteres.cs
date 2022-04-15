using Microsoft.VisualStudio.TestTools.UnitTesting;
using trainingCSharp;


namespace test_trainingCSharp
{
    [TestClass]
    public class Test_LesChainesDeCaracteres
    {
        [TestMethod]
        public void TestAreAnagrams_SimpleTrue()
        {
            Assert.AreEqual(true, trainingCSharp.LesChainesDeCaracteres.AreAnagrams("ABC", "CBA"), "Simple True");
        }
        [TestMethod]
        public void TestAreAnagrams_SimpleFalse()
        {
            Assert.AreEqual(false, trainingCSharp.LesChainesDeCaracteres.AreAnagrams("ABC", "XBA"), "Simple False");
        }

////////////////////////////////////////////////////////////////

        [TestMethod]
        public void TestIsPalindrome_SimpleFalse()
        {
            Assert.AreEqual(false, trainingCSharp.LesChainesDeCaracteres.IsPalindrome("ABC"), "Simple False");
        }
        [TestMethod]
        public void TestIsPalindrome_SimpleTrue()
        {
            Assert.AreEqual(true, trainingCSharp.LesChainesDeCaracteres.IsPalindrome("ABA"), "Simple True");
        }
        [TestMethod]
        public void TestIsPalindrome_SimpleFalse_Even()
        {
            Assert.AreEqual(false, trainingCSharp.LesChainesDeCaracteres.IsPalindrome("ABBC"), "Simple False Even");
        }
        [TestMethod]
        public void TestIsPalindrome_SimpleTrue_Even()
        {
            Assert.AreEqual(true, trainingCSharp.LesChainesDeCaracteres.IsPalindrome("ABBA"), "Simple True Even");
        }

        ////////////////////////////////////////////////////////////////

        [TestMethod]
        public void TestIsSubString_naive_SimpleFalse()
        {
            Assert.AreEqual(false, trainingCSharp.LesChainesDeCaracteres.IsSubString_naive("Premier Test de mot RND!!!", "XYZ"), "Simple False");
        }
        [TestMethod]
        public void TestIsSubString_naive_SimpleTrue()
        {
            Assert.AreEqual(true, trainingCSharp.LesChainesDeCaracteres.IsSubString_naive("Premier Test de mot RND!!!", "Test"), "Simple True");
        }
        [TestMethod]
        public void TestIsSubString_naive_LongFalse()
        {
            Assert.AreEqual(false, trainingCSharp.LesChainesDeCaracteres.IsSubString_naive("CAATGTCTGCACCAAGACGC------GTGCAGACCTTCGTTATAGGCGATGATTTCGAACCTACTAGTGGGTCTCTTAGGCCGAGCGGTTCCGAGAGATAGTGAAAGATGGCTGGGCTGTGAAGGGAAGGAGTCGTGAAAGCGCGAACACGAGTGTGCGCAAGCGCAGCGCCTTAGTATGCTCCAGTGTAGAAGCTCCGGCGTCCCGTCTAACCGTACGCTGTCCCCGGTACATGGAGCTAATAGGCTTTACTGCCCAATATGACCCCGCGCCGCGACAAAACAATAACAGTTT", "CGGCAG"), "Test Long False");
        }
        [TestMethod]
        public void TestIsSubString_naive_LongTrue()
        {
            Assert.AreEqual(true, trainingCSharp.LesChainesDeCaracteres.IsSubString_naive("CAATGTCTGCACCAAGACGCCGGCAGGTGCAGACCTTCGTTATAGGCGATGATTTCGAACCTACTAGTGGGTCTCTTAGGCCGAGCGGTTCCGAGAGATAGTGAAAGATGGCTGGGCTGTGAAGGGAAGGAGTCGTGAAAGCGCGAACACGAGTGTGCGCAAGCGCAGCGCCTTAGTATGCTCCAGTGTAGAAGCTCCGGCGTCCCGTCTAACCGTACGCTGTCCCCGGTACATGGAGCTAATAGGCTTTACTGCCCAATATGACCCCGCGCCGCGACAAAACAATAACAGTTT", "CGGCAG"), "Test Long True");
        }

        ////////////////////////////////////////////////////////////////

        [TestMethod]
        public void TestIsSubString_SimpleFalse()
        {
            Assert.AreEqual(false, trainingCSharp.LesChainesDeCaracteres.IsSubString("Premier Test de mot RND!!!", "XYZ"), "Simple False");
        }
        [TestMethod]
        public void TestIsSubString_SimpleTrue()
        {
            Assert.AreEqual(true, trainingCSharp.LesChainesDeCaracteres.IsSubString("Premier Test de mot RND!!!", "Test"), "Simple True");
        }
        [TestMethod]
        public void TestIsSubString_LongFalse()
        {
            Assert.AreEqual(false, trainingCSharp.LesChainesDeCaracteres.IsSubString("CAATGTCTGCACCAAGACGC------GTGCAGACCTTCGTTATAGGCGATGATTTCGAACCTACTAGTGGGTCTCTTAGGCCGAGCGGTTCCGAGAGATAGTGAAAGATGGCTGGGCTGTGAAGGGAAGGAGTCGTGAAAGCGCGAACACGAGTGTGCGCAAGCGCAGCGCCTTAGTATGCTCCAGTGTAGAAGCTCCGGCGTCCCGTCTAACCGTACGCTGTCCCCGGTACATGGAGCTAATAGGCTTTACTGCCCAATATGACCCCGCGCCGCGACAAAACAATAACAGTTT", "CGGCAG"), "Test Long False");
        }
        [TestMethod]
        public void TestIsSubString_LongTrue()
        {
            Assert.AreEqual(true, trainingCSharp.LesChainesDeCaracteres.IsSubString("CAATGTCTGCACCAAGACGCCGGCAGGTGCAGACCTTCGTTATAGGCGATGATTTCGAACCTACTAGTGGGTCTCTTAGGCCGAGCGGTTCCGAGAGATAGTGAAAGATGGCTGGGCTGTGAAGGGAAGGAGTCGTGAAAGCGCGAACACGAGTGTGCGCAAGCGCAGCGCCTTAGTATGCTCCAGTGTAGAAGCTCCGGCGTCCCGTCTAACCGTACGCTGTCCCCGGTACATGGAGCTAATAGGCTTTACTGCCCAATATGACCCCGCGCCGCGACAAAACAATAACAGTTT", "CGGCAG"), "Test Long True");
        }

    }
}