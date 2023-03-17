using System;

namespace LambdaDelegateExample
{
    class Program
    {
        delegate int StringLength(string str);

        static void Main(string[] args)
        {
            string[] words = { "apple", "banana", "orange", "kiwi", "grape" };

            StringLength length = s => s.Length;

            foreach (string word in words)
            {
                Console.WriteLine("Довжина рядка '{0}' = {1}", word, length(word));
            }

            Console.ReadKey();

        }
    }
}