using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppIntroduktionString.BIZ
{
    class ClassIO
    {
        public ClassIO()
        {

        }

        public void GetTestString(TextBox textBox)
        {
            textBox.Text = File.ReadAllText(@"..\..\Admiralen.txt");
        }
    }
}
