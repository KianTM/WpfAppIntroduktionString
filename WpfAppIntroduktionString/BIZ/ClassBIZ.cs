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
    }
}
