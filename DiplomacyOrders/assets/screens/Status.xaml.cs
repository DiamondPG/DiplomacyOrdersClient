using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Printing;
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

namespace DiplomacyOrders.assets.screens
{
    /// <summary>
    /// Interaction logic for Status.xaml
    /// </summary>
    public partial class Status : UserControl
    {
        public List<Country> body;

        /// <summary>
        /// Contains Status Page for Json
        /// </summary>
        /// <param name="json">Body of the API call formatted in the JSON object located at Status/Body</param>
        public Status(string json)
        {
            InitializeComponent();
            body = JsonConvert.DeserializeObject<List<Country>>(json);
            CountriesPanel.ItemsSource = body;
        }

        

        public class Country
        {
            public string Name { get; set; }
            public bool Ready { get; set; }
        }
    }
}
