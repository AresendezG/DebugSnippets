using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*

2N array of positive integers
N rounds in total

You have to choose any two positive integers from the array and delete them
The score in each round will be GDC(num1,num2)*round_number where num1 and num2 are numbers chosen 
total score is the sum of the scores that you have obtained in every round

Task: Determine the max total score 

 */

namespace DebugSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            string[] ParsedInput;
            int[] UserArray = { };
            Console.WriteLine("Enter your array separated by coma: ");
            UserInput =  Console.ReadLine();

            ParsedInput = UserInput.Split(',');
            
            foreach(string element in ParsedInput)
            {
                UserArray = InsertIntoArray(UserArray, Convert.ToInt32(element));
            }


            Combinations(UserArray);

            Console.Read();

        }


        /*
        
        1- Create an array with all possible number combinations
        2- Create an array with the size of N*CombinationArraySize where you will store all possible combinations of numbers picked
        3- Create 


        array = [a, b, c, d, e, f]

        combinations (no repeat):
        [a, b]
        [a, c]
        [a, d]
        [a, e]
        [a, f]
        [b, c]
        [b, d]
        [b, e]
        [b, f]
        [c, d]
        [c, e]
        [c, f]
        [d, e]
        [d, f]
        [e, f]


         */


        public static void Combinations(int[] Elements)
        {
            int SizeOfArray = Elements.Length;
            //int[][] AllPossibleCombinations;

            int ElementCount = 0;
            while (ElementCount < Elements.Length)
            {
                foreach (int PivotNumber in Elements)
                {
                    Elements = RemoveNumFromArray(Elements, 0);
                    foreach (int element in Elements)
                    {
                        Console.WriteLine("[" + PivotNumber + "," + element + "]");
                    }

                }

                ElementCount++;
            }
            

            return ;
        }

        public int GetMaxScore(int Rounds, int[] InputArray)
        {
            // check if Array size is truly 2N
            if (InputArray.Length == Rounds)
            {
                int TotalScore = 0;
                for (int i=0; i<Rounds; i++)
                {

                }
                return TotalScore;
            }
            else
            {
                Console.WriteLine("Error: This Array is missmatched!");
                return -1;
            }
        }

        public static int[] RemoveNumFromArray(int[] InputArray, int index)
        {
            var foos = new List<int>(InputArray);
            foos.RemoveAt(index);
            return foos.ToArray();
        }

        public static int[] InsertIntoArray(int[] InputArray, int Element)
        {
            var TempList = new List<int>(InputArray);
            TempList.Add(Element);
            return TempList.ToArray();
        }

    }
}
