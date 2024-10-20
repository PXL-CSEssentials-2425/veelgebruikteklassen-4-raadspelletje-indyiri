using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace H4Oef4Raadspelletje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            randomNumber = rnd.Next(1, 101);
        }

        Random rnd = new Random();
        int number = 0;
        int amountOfGuesses = 0;
        int randomNumber;

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}