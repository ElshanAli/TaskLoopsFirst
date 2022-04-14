using System;

namespace TaskLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words ");
            
            
            string[] wordsArr = new string[] { Console.ReadLine() };
            

            for (int i = 0; i < wordsArr.Length; i++)
            {
                if (wordsArr[i].Length > 5)
                {
                    Console.WriteLine(wordsArr[i] + " " + "Length is greater than 5");
                }
                else
                {
                    Console.WriteLine(wordsArr[i] + " " + "Length is less than 5");
                }
            }
          
        }
    }
}
