using Chess.ViewModels;
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

namespace Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameViewModel _gameViewModel;
        private HelpViewModel _helpViewModel = new HelpViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            _gameViewModel = new GameViewModel();
            _gameViewModel.Init();
            DataContext = _gameViewModel;
        }

        private void ContinueGame(object sender, RoutedEventArgs e)
        {
            DataContext = _gameViewModel;
        }

        private void HelpClick(object sender, RoutedEventArgs e)
        {
            DataContext = _helpViewModel;
        }
    }
}
