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
            Dictionary<string, string> dictionary = new()
            {
                {"tepm", "temporary" },
                {"name", "Jon Doe" }
            };
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
                    string[] str = s.Split('$');

                    string key1 = str[3];

                    if(dictionary.ContainsKey(key1))
                    {
                        
                    }
                }
                else
                {
                    dictionary.Add(key, s);
                }

            }
        }
    }
}
