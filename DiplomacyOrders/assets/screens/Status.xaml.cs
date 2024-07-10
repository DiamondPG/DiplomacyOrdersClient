using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public Body body = new Body();

        /// <summary>
        /// Contains Status Page for Json
        /// </summary>
        /// <param name="json">Body of the API call formatted in the JSON object located at Status/Body</param>
        public Status(string json)
        {
            InitializeComponent();
            body = JsonConvert.DeserializeObject<Body>(json);
            foreach (var item in body.Countries)
            {

            }
        }

        public class Body
        {
            public ObservableCollection<Country> Countries { get; set; }
            public class Country
            {
                public string Name { get; set; }
                public bool Ready { get; set; }
            }
        }
    }
}
