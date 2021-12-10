using System;

namespace WordFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result1 = FindWord(new char[,] { { 'x', 'y', 'z' }, { 'd', 'o', 'g' }, { 'a', 'b', 'c' } }, "dog");
            var result2 = FindWord(new char[,] { { 'z', 'c', 'x', 'a' }, { 'q', 'a', 'a', 't' }, { 'g', 't', 'g', 'l' } }, "cat");
            var result3 = FindWord(new char[,] { { 'z', 'c', 'x', 'a' }, { 'q', 'a', 'a', 't' }, { 'g', 't', 'g', 'l' } }, "dog");
            
            Console.WriteLine($"Availability of Dog horizontally is {result1}");
            Console.WriteLine($"Availability of Cat vertically is {result2}");
            Console.WriteLine($"Availability of Dog vertically is {result3}");
        }

        public static bool FindWord(char[,] matrix, string wordToFind)
        {
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            var word = wordToFind.ToCharArray();
            int indexofChar = 0;
            //Horizontal find
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == word[indexofChar])
                    {
                        if (indexofChar == word.Length - 1)
                        {
                            return true;
                        }

                        indexofChar++;

                    }

                }

            }
            indexofChar = 0;
            //Vertical find

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < rows; j++)
                {

                    if (matrix[j, i] == word[indexofChar])
                    {
                        if (indexofChar == word.Length - 1)
                        {
                            return true;
                        }

                        indexofChar++;

                    }

                }
            }
            return false;
        }
    }
}