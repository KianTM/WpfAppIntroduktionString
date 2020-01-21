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
    }
}
