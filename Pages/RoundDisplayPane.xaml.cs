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
using static RPSLSpock.Functionality;

namespace RPSLSpock.Pages
{
    /// <summary>
    /// Interaction logic for RoundDisplayPane.xaml
    /// </summary>
    public partial class RoundDisplayPane : Page
    {
        GameWindow window;
        public RoundDisplayPane(string outcome, GameWindow window)
        {
            InitializeComponent();
            RoundDisplayViewModel viewModel = new RoundDisplayViewModel();
            viewModel.Outcome = outcome;
            DataContext = viewModel;
            this.window = window;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SelectionPane selectionPane = new SelectionPane(window);
            window.frm_Display.Navigate(selectionPane);
        }
    }

    public class RoundDisplayViewModel
    {
        private string _Outcome;

        public string Outcome
        {
            get { return _Outcome; }
            set { _Outcome = value; }
        }

    }
}
