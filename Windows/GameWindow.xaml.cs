using RPSLSpock.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPSLSpock
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public  int AIScore=0;
        public  int HumanScore=0;
        SelectionPane select;
        public GameWindowViewModel viewModel;
        public GameWindow()
        {
            Functionality function = new Functionality();
            InitializeComponent();
            viewModel = new GameWindowViewModel(this);
            DataContext = viewModel;
            select = new SelectionPane(this);
            frm_Display.Navigate(select);
        }

        public void UpdateScoreBoxes()
        {
            lb_AIScore.Content = AIScore;
            lb_HumanScore.Content = HumanScore;
        }
    }

    public class GameWindowViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            gameWindow.InitializeComponent();
        }

        private int _AIScore;
        public int AIScore
        {
            get { return gameWindow.AIScore; }
            set
            {
                _AIScore = value;
                NotifyPropertyChanged();
            }
        }

        private GameWindow gameWindow;

        public GameWindowViewModel(GameWindow gameWindow)
        {
            this.gameWindow = gameWindow;
        }

        private int _HumanScore;
        public int HumanScore
        {
            get { return gameWindow.HumanScore; }
            set
            {
                _HumanScore = value;
                NotifyPropertyChanged();
            }
        }
    }
}
