using DiplomacyOrders.assets.screens;
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

namespace DiplomacyOrders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Home home = new Home();
        Map map = new Map();
        SubmitOrders orders = new SubmitOrders();
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Content.Content = home;
        }

        private void CloseBTN_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeBTN_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Border_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            Content.Content = home;
        }
        private void ViewMapBTN_Click(object sender, EventArgs e)
        {
            Content.Content = map;
        }
        private void OrdersBTN_Click(object sender, EventArgs e)
        {
            Content.Content = orders;
        }
    }
}