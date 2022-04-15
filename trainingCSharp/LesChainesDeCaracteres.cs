

namespace trainingCSharp
{
    public class LesChainesDeCaracteres
    {
        // N! anagrams possibles
        // Complexite: O(N^2)
        public static bool AreAnagrams(string str1, string str2)
        /*        {
                    if (motA.Length != motB.Length)
                        return false;
        //TODO a refaire
                    List<char> motB_list = motB.ToList<char>();
                    foreach (char cA in motA)
                    {
                        if (!motB_list.Remove(cA))
                            return false;
                    }

                    return true;
                }
        */
        {
            if (str1.Length != str2.Length)
                return false;
            if (str1 == str2)
                return true;
            //based on 128 ASCII characeters. 
            //You can change the paramter depending on requirement
            int charLength = 128;
            int[] counter = new int[charLength];
            for (int i = 0; i < str1.Length; ++i)
            {
                var xx = str1[i] - '0';
                                ++counter[str1[i] - '0'];
                                --counter[str2[i] - '0'];
            }
            for (int c = 0; c < charLength; ++c)
            {
                if (counter[c] != 0) return false;
            }
            return true;
        }
        // Complexite: O(N)
        public static bool IsPalindrome(string mot)
        {
            int length_1 = mot.Length - 1;
            int length_2 = mot.Length / 2;

            for (int i=0; i< length_2; ++i)
            {
                if (mot[i] != mot[length_1-i])
                {
                    Console.WriteLine("False: chars i = " + i + ", n-1-i = " + (length_1-i));
                    return false;
                }
            }
            Console.WriteLine("This is a palyndrom: " + mot);

            return true;
        }

        public static Boolean IsSubString_naive(string str, string subStr)
        {
            if (subStr.Length > str.Length)
                return false;

            for (int i = 0; i <str.Length - subStr.Length - 1; ++i)
            {
                int nbCharMatched = 0;
                for (nbCharMatched = 0; nbCharMatched < subStr.Length; ++nbCharMatched)
                {
                    if (str[i+nbCharMatched] != subStr[nbCharMatched])
                        break;
                }
                if (nbCharMatched == subStr.Length)
                    return true;
            }

            return false;
        }

        public static Boolean IsSubString(string str, string subStr)
        {
            if (subStr.Length > str.Length)
                return false;

            int i = subStr.Length-1;
            while (i < str.Length)
            {
                bool isMatch = true;
                int nbCharMatched = 0;
                int charLikeLast = -1;
                for (nbCharMatched = 0; ((nbCharMatched < subStr.Length) && (isMatch || charLikeLast == -1)); ++nbCharMatched)
                {
                    if ((charLikeLast == -1) && (nbCharMatched > 0) && (str[i] == subStr[subStr.Length - 1 - nbCharMatched]))
                        charLikeLast = nbCharMatched;
                    if (str[i - nbCharMatched] != subStr[subStr.Length-1-nbCharMatched])
                        isMatch = false;
                }
                if (isMatch)
                    return true;
                else
                {
                    if (charLikeLast == -1)
                        i += subStr.Length;
                    i += charLikeLast;
                }
            }

            return false;
        }

        public static double[] moneyeur(int inputMoney)
        {
            double[] allowedInput  = {50, 100, 200};
            double[] allowedOutput = {0.5, 1, 2, 5, 10, 20, 50};

            if (! allowedInput.Contains(inputMoney))
                throw new Exception("Unhandled input: " + inputMoney);

            //TODO
            return null;
        }

        //TODO: PK le type generic Array ne prend pas d'args
/*        public static int[] Merge(int[] tabA, int[] tabB)
        {
            int[] result = new int[tabA.Length + tabB.Length];

            int resultIndex = 0, a=0, b=0;

            while ((a<tabA.Length) && (b < tabB.Length))
            {
                Array toCopyArray;
                int valMax, toCopyLowerBound, toCopyUpperBound;
                if (tabA[a] <= tabB[b])
                {
                    toCopyArray     = tabA;
                    valMax          = tabB[b];
                    toCopyLowerBound= a;
                    toCopyUpperBound= tabA.Length;
                }
                else
                {
                    toCopyArray     = tabB;
                    valMax          = tabA[a];
                    toCopyLowerBound= b;
                    toCopyUpperBound= tabB.Length;
                }
                int nbElem = toCopyLowerBound;
                while ( (toCopyArray.GetValue(i) <= valMax) && (toCopyLowerBound+nbElem< toCopyUpperBound))
                    nbElem++;

                Array.Copy(toCopyArray, toCopyLowerBound, result, resultIndex, nbElem);

                resultIndex += nbElem;
                if (tabA.GetValue(a) <= tabB.GetValue(b))
                    a += nbElem;
                else
                    b += nbElem;
            }
            if (a < tabA.Length)
                Array.Copy(tabA, a, result, resultIndex, tabA.Length - a);
            else
                Array.Copy(tabB, b, result, resultIndex, tabB.Length - b);

            return result;
        }
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Boolean res = LesChainesDeCaracteres.IsSubString("CAATGTCTGCACCAAGACGCCGGCAGGTGCAGACCTTCGTTATAGGCGATGATTTCGAACCTACTAGTGGGTCTCTTAGGCCGAGCGGTTCCGAGAGATAGTGAAAGATGGCTGGGCTGTGAAGGGAAGGAGTCGTGAAAGCGCGAACACGAGTGTGCGCAAGCGCAGCGCCTTAGTATGCTCCAGTGTAGAAGCTCCGGCGTCCCGTCTAACCGTACGCTGTCCCCGGTACATGGAGCTAATAGGCTTTACTGCCCAATATGACCCCGCGCCGCGACAAAACAATAACAGTTT", "CGGCAG");
            Console.WriteLine("Result = " + res);
        }
    }
}
