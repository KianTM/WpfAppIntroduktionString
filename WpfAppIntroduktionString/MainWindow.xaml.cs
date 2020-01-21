using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppIntroduktionString.BIZ;

namespace WpfAppIntroduktionString
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ cb = new ClassBIZ();

        public MainWindow()
        {
            InitializeComponent();

            cb.GetTestString(textBoxLeft);
        }

        private void opg8Button_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Text = cb.CountAllLines(textBoxLeft).ToString();
        }

        private void opg1Button_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Text = cb.CountAllChars(textBoxLeft).ToString();
        }
    }
}
