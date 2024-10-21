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
using Microsoft.VisualBasic;

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
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int number = -1;
            int amountOfGuesses = 0;
            int randomNumber = rnd.Next(0, 101);

            string input = Interaction.InputBox("Geef een getal tussen 0 en 100", "Raadspel");
            bool isInputValid = int.TryParse(input, out number);

            while (number != randomNumber)
            {

                if (string.IsNullOrEmpty(input) || !isInputValid)
                {
                    MessageBox.Show("Geef een getal in!", "Foutieve invoer", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else if (number < 0 || number > 100)
                {
                    MessageBox.Show("Geef een getal in tussen 0 en 100!", "Foutieve invoer", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else if (number < randomNumber)
                {
                    MessageBox.Show("Raad hoger!");
                    amountOfGuesses++;
                }
                else
                {
                    MessageBox.Show("Raad lager!");
                    amountOfGuesses++;
                }                    
                input = Interaction.InputBox("Geef een getal tussen 0 en 100", "Raadspel");
            }
            MessageBox.Show($"Proficiat! U hebt het getal geraden! Aantal keer geraden: {amountOfGuesses}", "Gewonnen");
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}