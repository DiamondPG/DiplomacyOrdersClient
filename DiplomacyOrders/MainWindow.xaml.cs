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
using Rest;
using System.Net.Http;
using System.Diagnostics;

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

        private void SendRequest()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("http://localhost:6727/status")
                };
                Task.Run(async () =>
                {
                    var response = await client.SendAsync(request);
                    var body = await response.Content.ReadAsStringAsync();
                    Trace.WriteLine(body);
                });
            }
            catch
            {
                throw new NotImplementedException("Error not documented");
            }
            
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

        private void Status_Click(object sender, RoutedEventArgs e)
        {
            
        }


    }
}