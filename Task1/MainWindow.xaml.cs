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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        private void RollDiceButton_Click(object sender, RoutedEventArgs e)
        {
            int dice1 = random.Next(1, int.Parse(Dice1SidesTextBox.Text) + 1);
            int dice2 = random.Next(2, int.Parse(Dice2SidesTextBox.Text) + 1);
            int total = dice1 + dice2;

            Dice1ResultLabel.Content = dice1.ToString();
            Dice2ResultLabel.Content = dice2.ToString();
            TotalResultLabel.Content = total.ToString();

            int guessedNumber = int.Parse(GuessedNumberTextBox.Text);
            double probability = 1.0 / (int.Parse(Dice1SidesTextBox.Text) * int.Parse(Dice2SidesTextBox.Text));

            if (guessedNumber == total)
            {
                ProbabilityLabel.Content = "Вероятность угадывания: 100%";
            }
            else
            {
                ProbabilityLabel.Content = $"Вероятность угадывания: {probability:P}";
            }
        }
    }
}
