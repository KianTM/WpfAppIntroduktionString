using System.Windows;
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

        private void opg1Button_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Text = cb.CountAllLines(textBoxLeft).ToString();
        }

        private void opg2Button_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Text = cb.CountAllChars(textBoxLeft).ToString();
        }

        private void opg3Button_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Text = cb.CountAllVowels(textBoxLeft).ToString();
        }

        private void opg4Button_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Text = cb.RemoveAllVowels(textBoxLeft);
        }
    }
}
