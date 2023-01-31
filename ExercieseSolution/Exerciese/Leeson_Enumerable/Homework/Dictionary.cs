using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese.Leeson_Enumerable.Homework
{
    public class Dictionary
    {
        public static void Run()
        {
            Dictionary<string, string> dictionary = new();
            while (true)
            {
                Console.Write("s: ");
                string s = Console.ReadLine();
                // "$temp$", ["temp": "temporary"]
                int startIndex = s.IndexOf('$') + 1;
                int endIndex = s.IndexOf('$', startIndex);

                string key = s.Substring(startIndex, endIndex - startIndex);

                bool isHave = dictionary.ContainsKey(key);

                int valueIndex = s.IndexOf($"\"{key}\": \"") + key.Length + 5;
                int valueEndIndex = s.IndexOf("\"]");
                string value = s.Substring(valueIndex, valueEndIndex - valueIndex);
                Console.WriteLine("key: " + key + "\tvalue: " + value);

                if (isHave)
                {
                    int i = s.IndexOf('$',endIndex+1)+1;
                    int j = s.IndexOf('$', i + 1);

                    Console.WriteLine(i);
                    Console.WriteLine(j);
                    string key1 = s.Substring(i, s.Length-i-j);

                    Console.WriteLine("key1: " + key1);
                }
                else
                {
                    dictionary.Add(key, s);
                }

            }
        }
    }
}
