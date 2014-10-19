using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>();
            var wordRepeats = new Dictionary<string, int>();

            //add all words from console
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            //find number of repeats for any word
            foreach (var word in words)
            {
                int repeats = words.FindAll(s => s.Equals(word)).Count();

                wordRepeats[word] = repeats;
            }

            //sort words by number of repeats
            var sortedWordRepeats = wordRepeats.OrderByDescending(s => s.Value);
            var firstElement = sortedWordRepeats.First();

            //print number of repeats
            Console.WriteLine("{0}", firstElement.Value);

            //print word
            for (int i = 0; i < firstElement.Value; i++)
            {
                Console.WriteLine("{0}", firstElement.Key);
            }

            Console.WriteLine();
        }
    }
}