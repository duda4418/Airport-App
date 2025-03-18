using Airport_App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareMemorie
{
    public class AdministrareMemoriePassenger
    {
        public void ProcessWords(string filePath)
        {
     
            string[] words = File.ReadAllLines(filePath);
            string[][] sortedWords = new string[26][];

            for (int i = 0; i < 26; i++)
            {
                sortedWords[i] = new string[0];
            }

            foreach (string word in words)
            {
                if (string.IsNullOrWhiteSpace(word)) continue;

                char firstLetter = char.ToLower(word[0]);
                if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    int index = firstLetter - 'a';
                    Array.Resize(ref sortedWords[index], sortedWords[index].Length + 1);
                    sortedWords[index][sortedWords[index].Length - 1] = word;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (sortedWords[i].Length > 0)
                {
                    Console.WriteLine($"Litera {(char)('A' + i)}:");
                    Console.WriteLine(string.Join(", ", sortedWords[i]));
                }
            }
        }
    }

}
