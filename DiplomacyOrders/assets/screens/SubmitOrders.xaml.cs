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

namespace DiplomacyOrders.assets.screens
{
    /// <summary>
    /// Interaction logic for SubmitOrders.xaml
    /// </summary>
    public partial class SubmitOrders : UserControl
    {
        public SubmitOrders()
        {
            InitializeComponent();
        }

        private string GetLastRow()
        {
            string[] rows = OrdersTXT.Text.Split("\n");
            return rows[rows.Length - 1];
        }

        private void CorrectOrders(string lastRow, string? input)
        {
            string[] sections = OrdersTXT.Text.Split(" ");
            
        }

        private void OrdersTXT_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key != null)
            {
                switch (e.Key)
                {
                    case Key.A:
                        CorrectOrders(GetLastRow(), "A");
                        break;
                    case Key.F:
                        CorrectOrders(GetLastRow(), "F");
                        break;
                    case Key.Space:
                        CorrectOrders(GetLastRow(), "Space");
                        break;
                }
            }
        }
    }
}
