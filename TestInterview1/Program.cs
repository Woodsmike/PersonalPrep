using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace TestInterview1
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----------return a matrix counterclockwise---------------
            int[,] a = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
           
            RotateMatrixCounterClockwise(a);
            
            int[,] RotateMatrixCounterClockwise(int[,] oldMatrix)
            {
                int[,] newMatrix = new int[a.GetLength(1), a.GetLength(0)];
                int newColumn, newRow = 0;
                for (int oldColumn = a.GetLength(1) - 1; oldColumn >= 0; oldColumn--)
                {
                    newColumn = 0;
                    for (int oldRow = 0; oldRow < a.GetLength(0); oldRow++)
                    {
                        newMatrix[newRow, newColumn] = a[oldRow, oldColumn];
                        newColumn++;
                    }
                    newRow++;
                }
                int rowLength = newMatrix.GetLength(0);
                int colLength = newMatrix.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write($"{newMatrix[i,j]}");
                    }
                    Console.WriteLine();
                }
                return newMatrix;
            }
            Console.WriteLine();
            //---------------return a matrix clockwise-------------------
            int[,] b = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            
            int[,] rotated = RotateMatrix(b, 3);

            int[,] RotateMatrix(int[,] matrix, int n)
            {
                int[,] ret = new int[n, n];

                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        ret[i, j] = matrix[n - j - 1, i];
                    }
                }
                int rowLength = ret.GetLength(0);
                int colLength = ret.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write($"{ret[i,j]}");
                    }
                    Console.WriteLine();
                }
                
                return ret;
            }

            //the first non repeating character in a string
            //    string v = "bsbaisidkbas";
            //    Console.WriteLine(firstNotRepeatingCharacter(v));
            //    char firstNotRepeatingCharacter(string s)
            //    {
            //        int repeated = 0;
            //        char print = ' ';
            //        char blank = '_';
            //        if (s.Length == 1)
            //        {
            //            print = s[0];
            //            return print;
            //        }            
            //        else
            //        {
            //            string t = s;
            //            for (int i = 0; i < t.Length - 1; i++)
            //            {
            //                repeated = 0;
            //                for (int j = 1; j < t.Length; j++)
            //                {
            //                    if (i != j && t[i] == t[j])
            //                    {
            //                        repeated = 1;
            //                        break;
            //                    }
            //                }
            //                if (repeated == 0)
            //                {
            //                    print = t[i];
            //                    break;
            //                }
            //            }
            //            if (repeated == 1)
            //            {
            //                return blank;
            //            }
            //            else
            //            {
            //                return print;
            //            }
            //        }
            //    }

            //-------finding the first duplicate with the second occurrence which has the minimal index-------
            //int[] a = new int[] { 1, 2, 3, 4, 2, 3, 1 };
            //Console.WriteLine(firstDuplicate(a));

            //int firstDuplicate(int[] first)
            //{
            //    Dictionary<int, int> secondOcc = new Dictionary<int, int>();
            //    foreach (int i in first)
            //    {
            //        if (secondOcc.ContainsKey(i))
            //            return i;
            //        else
            //            secondOcc.Add(i, 1);
            //    }
            //    return -1;
            //}


            //--------find the first number that duplicates----------
            //int[] b = { 1, 2, 3, 3, 4, 4, 5, 6, 3, 2, 1 };
            //Console.WriteLine(firstDuplicate(b));
            //int firstDuplicate(int[] a)
            //{
            //    int minimum = -1;
            //    int lowest = 0;

            //    for (int i = 0; i < a.Length - 1; i++)
            //    {
            //        for (int j = a.Length -1; j >= 0; j--)
            //        {
            //            if (a[i] == a[j])
            //            {
            //                lowest = a[j];
            //                minimum++;

            //            }

            //        }
            //    }
            //    if (minimum != -1)
            //    {
            //        return lowest;
            //    }
            //    else
            //    {
            //        return minimum;
            //    }
            //}

            // ---------find all numbers between 1-100 that is a prime number---------
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Print(i);
            //    }
            //}

            //public static bool IsPrime(int i)
            //{
            //    if (i == 0 || i == 1)
            //    {
            //        return false;
            //    }
            //    if (i == 2)
            //    {
            //        return true;
            //    }
            //    if (i % 2 == 0)
            //    {
            //        return false;
            //    }
            //    for (int x = 3; (x * x) <= i; x += 2)
            //    {
            //        if ((i % x) == 0)
            //        {
            //            return false;
            //        }

            //    }
            //    return true;

            //}


            //------------print out char array in reverse--------------
            //char[] word = { 'b', 'a', 'c', 'k' };
            //char a = ' ';
            //int b = word.Length - 1;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}
            //for (int i = 0; i < word.Length - 1; i++)
            //{
            //    a = word[i];

            //    for (int j = b; j > i;)
            //    {
            //        word[i] = word[j];
            //        b--;
            //        word[j] = a;
            //        break;
            //    }
            //}
            //for (int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}
            //--------String compression-------

            //    string input = "aavvvvvqqqsss";
            //    string output = Cstr(input);
            //    Console.WriteLine(output);
            //    Console.ReadLine();
            //}

            //public static String Cstr(String a)
            //{
            //    if (a == null)
            //    {
            //        return null;
            //    }
            //    if (a == "")
            //    {
            //        return "Please enter some letters";
            //    }
            //    a = a.ToLower();
            //    char[] chars = a.ToCharArray();

            //    StringBuilder sb = new StringBuilder();
            //    int count = 0;
            //    for (int i = 0; i < chars.Length; i++)
            //    {
            //        if (chars[i] < 'a' || chars[i] > 'z') continue;
            //        if (sb.Length == 0)
            //        {
            //            sb = sb.Append(chars[i]);
            //            count = 1;
            //        }
            //        else if (chars[i] == chars[i - 1])
            //        {
            //            count++;
            //        }
            //        else
            //        {                   
            //            sb = sb.Append(count.ToString());
            //            sb = sb.Append(chars[i]);
            //            count = 1;
            //        }
            //    }
            //    sb = sb.Append(count.ToString());
            //    return sb.ToString();
            //}



            //--------one away.. 2 strings that are one edit (or none) away from matching --------
            //------Levenshtein -------


            //    string a = "aunto";
            //    string b = "aunte";
            //    List<string[]> first = new List<string[]>()
            //    {
            //    new string[]{a,b}
            //    };
            //    foreach (string[] c in first)
            //    {
            //        int dif = Compute(c[0], c[1]);
            //        if (dif == 0 || dif == 1)
            //        {
            //            Console.WriteLine("{0} and {1} => true", a, b);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} and {1} => false", a, b);
            //        }

            //    }

            //}

            //private static int Compute(string a, string b)
            //{
            //    int n = a.Length;
            //    int m = b.Length;
            //    int[,] d = new int[n + 1, m + 1];

            //    // Step 1
            //    if (n == 0)
            //    {
            //        return m;
            //    }

            //    if (m == 0)
            //    {
            //        return n;
            //    }

            //    // Step 2
            //    for (int i = 0; i <= n; d[i, 0] = i++)
            //    {
            //    }

            //    for (int j = 0; j <= m; d[0, j] = j++)
            //    {
            //    }

            //    // Step 3
            //    for (int i = 1; i <= n; i++)
            //    {
            //        //Step 4
            //        for (int j = 1; j <= m; j++)
            //        {
            //            // Step 5
            //            int cost = (b[j - 1] == a[i - 1]) ? 0 : 1;

            //            // Step 6
            //            d[i, j] = Math.Min(
            //                Math.Min(d[i - 1, j] + 1,
            //                d[i, j - 1] + 1),
            //                d[i - 1, j - 1] + cost);
            //        }
            //    }
            //    // Step 7

            //    return d[n, m];
            //}

            // ---------- is a string a permutation of a palindrome-------


            //    bool isPalin = IsPalPerm("TAC TCC O CATT");
            //    Console.WriteLine(isPalin);

            //}
            //private static bool IsPalPerm(string str)
            //{
            //    int len = str.Length;
            //    char ch;
            //    int count = 0;
            //    char? oddChr = null;

            //    // to get the no. of characters in the string, ignoring the spaces. 
            //    for (int k = 0; k < str.Length; k++)
            //    {
            //        if (str[k] == ' ')
            //            len--;
            //    }

            //    for (int i = 0; i < str.Length; i++)
            //    {                
            //        if (str[i] == ' ') // ignore the space.
            //        {
            //            continue;
            //        }
            //        ch = str[i];
            //        count = 0;
            //        for (int k = 0; k < str.Length; k++)
            //        {
            //            if (str[k] == ' ')
            //                continue;

            //            if (str[k] == ch) count++; // count the occurrence of the character in the string.
            //        }
            //        // if the occurrence is even then its ok. 
            //        // else check for other details
            //        if (count % 2 != 0)
            //        {
            //            // if length is even that means it cant 
            //            // have any characters with odd occurrence.
            //            if (len % 2 == 0)
            //                return false;
            //            // if the length is odd then it can have 
            //            // only one character with odd occurrence.
            //            else if (oddChr.HasValue && (oddChr.Value != ch))
            //                return false;
            //            else
            //                // this is the first character found with the odd 
            //                // occurrence in a odd length string. save it.
            //                oddChr = ch;
            //        }
            //    }
            //    return true;
            //}

            // ------Without Regex, Replace spaces with %20 ---------


            //    string s = "Mr John    Smith";
            //    Console.WriteLine(Replace(s));
            //}

            //public static string Replace(string s)
            //{
            //    s = s.Trim();
            //    s = s.Replace(" ", "%20");
            //    return s;
            //}


            //------ Replace spaces with %20 (Regex) -----

            //    string str = "Mr Jon  Smith  ";

            //    Console.WriteLine(ReplaceAllSpaces(str));

            //}
            //public static string ReplaceAllSpaces(string str)
            //{
            //    return Regex.Replace(str, @"\s+", "%20");


            //----------------------------------
            // ------ Permutation ---------


            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();

            //    if(IsPerm(a, b))
            //    {
            //        Console.WriteLine("These are permutations");
            //    }
            //    else
            //    {
            //        Console.WriteLine("These are not permutations");
            //    }

            //}
            //private static bool IsPerm(string a, string b)
            //{
            //    if (a.Length != b.Length)
            //        return false;
            //    int[] charCount = new int[256];
            //    int charIndex;

            //    for(int index = 0; index <256; index++)
            //    {
            //        charCount[index] = 0;
            //    }
            //    foreach (char myChar in a.ToCharArray())
            //    {
            //        charIndex = myChar;
            //        charCount[charIndex]++;
            //    }
            //    foreach (char myChar in b.ToCharArray())
            //    {
            //        charIndex = myChar;
            //        charCount[charIndex]--;
            //    }
            //    for (int index = 0; index < 256; index++)
            //    {
            //        if (charCount[index] != 0) return false;
            //    }
            //    return true;

            //
            //--------------------------------------------
            //   ---------IsUnique Question ---------


            //    Console.WriteLine("Please enter a string");
            //    string s = Console.ReadLine().ToLower();
            //    Console.WriteLine(IsUnique(s));

            //}

            //public static bool IsUnique(string s)
            //{
            //    for (var i = 0; i < s.Length - 1; i++)
            //    {
            //        for (var k = i + 1; k < s.Length; k++)
            //        {
            //            if (s[i] == s[k])
            //                return false;
            //        }
            //    }
            //    return true;
            //}

            //public static void Print(int i)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}