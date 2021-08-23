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

namespace RPSLSpock.Pages
{
    /// <summary>
    /// Interaction logic for SelectionPane.xaml
    /// </summary>
    public partial class SelectionPane : Page
    {
        GameWindow window;
        Functionality function;
        string outcome;
        public SelectionPane(GameWindow gameWindow)
        {
            InitializeComponent();
            window = gameWindow;
            function = new Functionality();

        }

        private void btn_Rock_Click(object sender, RoutedEventArgs e)
        {
            outcome = function.CheckWinner(function.AISelection(), Functionality.Choices.Rock).ToString() ;
            IncrementScore(outcome);
            window.UpdateScoreBoxes();
            window.frm_Display.Navigate(new RoundDisplayPane(outcome, window));

        }

        private void btn_Paper_Click(object sender, RoutedEventArgs e)
        {
            outcome = function.CheckWinner(function.AISelection(), Functionality.Choices.Paper).ToString();
            IncrementScore(outcome);
            window.UpdateScoreBoxes();
            window.frm_Display.Navigate(new RoundDisplayPane(outcome, window));
        }

        private void btn_Scissors_Click(object sender, RoutedEventArgs e)
        {
            outcome = function.CheckWinner(function.AISelection(), Functionality.Choices.Scissors).ToString();
            IncrementScore(outcome);
            window.UpdateScoreBoxes();
            window.frm_Display.Navigate(new RoundDisplayPane(outcome, window));
        }

        private void btn_Lizard_Click(object sender, RoutedEventArgs e)
        {
            outcome = function.CheckWinner(function.AISelection(), Functionality.Choices.Lizard).ToString();
            IncrementScore(outcome);
            window.UpdateScoreBoxes();
            window.frm_Display.Navigate(new RoundDisplayPane(outcome, window));
        }

        private void btn_Spock_Click(object sender, RoutedEventArgs e)
        {
            outcome = function.CheckWinner(function.AISelection(), Functionality.Choices.Spock).ToString();
            IncrementScore(outcome);
            window.UpdateScoreBoxes();
            window.frm_Display.Navigate(new RoundDisplayPane(outcome, window));
        }

        private void IncrementScore(string outcome)
        {
            switch (outcome)
            {
                case "Win":
                    window.HumanScore++;
                    break;
                case "Lose":
                    window.AIScore++;
                    break;
            }
        }
    }
}
