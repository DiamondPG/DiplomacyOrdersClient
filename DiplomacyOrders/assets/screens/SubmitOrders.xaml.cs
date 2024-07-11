using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
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
using System.Windows.Media.Animation;
using System.Windows.Threading;


namespace DiplomacyOrders.assets.screens
{
    /// <summary>
    /// Interaction logic for SubmitOrders.xaml
    /// </summary>
    public partial class SubmitOrders : UserControl
    {
        Dictionary<string, List<string>> acronyms = new Dictionary<string, List<string>>();
        public SubmitOrders()
        {
            InitializeComponent();
            acronyms = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(File.ReadAllText("./assets/data/countries.json"));
        }

        private string GetLastRow()
        {
            string[] rows = OrdersTXT.Text.Split("\n");
            return rows[rows.Length - 1];
        }
        bool armyFleetDeclaration = false;
        private void CorrectOrders(string lastRow, string input)
        {
            string[] sections = OrdersTXT.Text.Split(" ");
            string entry = sections.Last();
            Trace.WriteLine(entry);
            switch (input)
            {
                case "Space":
                    if(!armyFleetDeclaration)
                    {
                        foreach (var entree in acronyms)
                        {
                            if (entree.Value.Contains(entry, StringComparer.OrdinalIgnoreCase))
                            {
                                Trace.WriteLine($"Found '{entry}' under acronym: {entree.Key}");
                                entry = entree.Key;
                                break;
                            }
                        }
                    }
                    if(entry.ToLower() == "s" || entry.ToLower() == "sup")
                    {
                        entry = "Support";
                    }
                    if (entry.ToLower() == "a")
                    {
                        entry = "Army";
                    }
                    if (entry.ToLower() == "f")
                    {
                        entry = "Fleet";
                    }
                    if (entry.ToLower() == "m" || entry.ToLower() == "move")
                    {
                        entry = " - ";
                    }
                    if(entry.ToLower() == "c")
                    {
                        entry = "Convoy";
                    }
                    if (entry.ToLower() == "v")
                    {
                        entry = "Via";
                    }
                    break;
                case "Enter":
                    entry = "\n";
                    break;
            }
            sections[sections.Length - 1] = entry;
            string text = "";
            foreach(string section in sections)
            {
                text += section + " ";
            }
            OrdersTXT.Text = text;
            OrdersTXT.CaretIndex = text.Length;
            
        }

        private void OrdersTXT_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key != null)
            {
                switch (e.Key)
                {
                    
                    case Key.Space:
                        CorrectOrders(GetLastRow(), "Space");
                        break;
                    case Key.Enter:
                        CorrectOrders(GetLastRow(), "Enter");
                        break;
                }
            }
        }

        private void SubmitBTN_Click(object sender, RoutedEventArgs e)
        {
            Submit();
        }

        private void ShowAnimation(string text)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.Duration = new Duration(new TimeSpan(0, 0, 1));
            anim.EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseIn};
            anim.From = 0;
            anim.To = 100;
            EventDisplay.BeginAnimation(UIElement.OpacityProperty, anim);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            (sender as DispatcherTimer).Stop();
            EndAnimation();
        }

        private void EndAnimation()
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.Duration = new Duration(new TimeSpan(0, 0, 1));
            anim.EasingFunction = new QuadraticEase();
            anim.From = 100;
            anim.To = 0;
            EventDisplay.BeginAnimation(UIElement.OpacityProperty, anim);
        }

        private async void Submit()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://localhost:6727/submit"),
                Content = new StringContent("{\n\t\"nation\": \"France\",\n\t\"name\": \"Phoebe31\",\n\t\"orders\": \"test2\"\n}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                ShowAnimation("Orders Submitted");
            }
        }
    }
}
