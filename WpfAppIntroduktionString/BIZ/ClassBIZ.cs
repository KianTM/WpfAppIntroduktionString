using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppIntroduktionString.BIZ
{
    class ClassBIZ
    {
        public ClassBIZ()
        {

        }

        public void GetTestString(TextBox textBox)
        {
            ClassIO cio = new ClassIO();

            cio.GetTestString(textBox);
        }

        public int CountAllLines(TextBox textBox)
        {
            int result = 0;

            int lineCount = textBox.LineCount;

            for (int i = 0; i < lineCount; i++)
            {
                if (textBox.GetLineText(i).Trim().Length > 0)
                {
                    result++;
                }
            }

            return result;
        }

        public int CountAllChars(TextBox textBox)
        {
            int result = textBox.Text.Trim().Length;

            return result;
        }

        public int CountAllVowels(TextBox textBox)
        {
            int result = 0;

            foreach (char c in textBox.Text)
            {
                switch (c)
                {
                    case 'a':
                        result++;
                        break;
                    case 'e':
                        result++;
                        break;
                    case 'i':
                        result++;
                        break;
                    case 'o':
                        result++;
                        break;
                    case 'u':
                        result++;
                        break;
                    case 'y':
                        result++;
                        break;
                    case 'æ':
                        result++;
                        break;
                    case 'ø':
                        result++;
                        break;
                    case 'å':
                        result++;
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        public string RemoveAllVowels(TextBox textBox)
        {
            string output = textBox.Text.ToLower().Replace("a", "")
                .Replace("e", "")
                .Replace("i", "")
                .Replace("o", "")
                .Replace("u", "")
                .Replace("y", "")
                .Replace("æ", "")
                .Replace("ø", "")
                .Replace("å", "");
            return output;
        }

        public string SearchAndReplace(TextBox textBox, string input)
        {
            string initialUpper = $"{input.Substring(0, 1).ToUpper()}{input.Substring(1)}";
            string output = textBox.Text.Replace(input, $"#>{input}")
                .Replace(initialUpper, $"#>{initialUpper}");

            return output;
        }

        public int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }

        public string CountNumberOfWordLength(TextBox textBox)
        {
            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
            string output = "";

            string[] strings = textBox.Text.Split(' ');

            foreach (var i in strings)
            {
                int length = i.Length;
                int value = 0;

                if (dictionary.TryGetValue(length, out value))
                {
                    value++;
                    dictionary[length] = value;
                }
                else
                {
                    dictionary.Add(length, 1);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<int, int> pair in dictionary)
            {
                string text = $"Ord med længde {pair.Key.ToString()}: {pair.Value.ToString()} stk";

                sb.AppendLine(text);
            }

            output = sb.ToString();

            return output;
        }

        public string CountAllWords(TextBox textBox)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            string output = "";

            string[] allWords = textBox.Text.Split().Select(x => x.TrimEnd(",.;:-".ToCharArray())).ToArray();

            foreach (var i in allWords)
            {
                string word = i;
                int value = 0;

                if (dictionary.TryGetValue(word, out value))
                {
                    value++;
                    dictionary[word] = value;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                string text = $"Ordet >> {pair.Key} << forekommer: {pair.Value} antal gange.";
                sb.AppendLine(text);
            }

            output = sb.ToString();

            return output;
        }
    }
}
