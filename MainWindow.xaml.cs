﻿using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

namespace WASP_Planner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("Events.json"))
            {
                using (FileStream stream = new FileStream("Events.json", FileMode.Open))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    string bufferText = Encoding.Default.GetString(buffer);
                    events = JsonSerializer.Deserialize<Dictionary<DateTime, string>>(bufferText);
                }
            }
            else
            {
                string serializedEvents = JsonSerializer.Serialize(events);
                using (FileStream stream = new FileStream("Events.json", FileMode.Create))
                {
                    byte[] buffer = Encoding.Default.GetBytes(serializedEvents);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        private void OnDateTextBlockInitialized(object sender, EventArgs e)
        {
            (sender as TextBlock).Text = DateTime.Now.ToString("D", CultureInfo.GetCultureInfo("ru-RU"));
        }

        private void onGridResize(object sender, SizeChangedEventArgs e)
        {
            if (e.PreviousSize.Height == 0 || e.PreviousSize.Width == 0)
            {
                return;
            }
            double scaleX = e.NewSize.Height / e.PreviousSize.Height;
            double scaleY = e.NewSize.Width / e.PreviousSize.Width;
            foreach (UIElement u in (sender as Grid).Children)
            {
                FrameworkElement f = u as FrameworkElement;
                f.Height = f.Height * scaleX;
                f.Width = f.Width * scaleY;
                f.Margin = new Thickness(f.Margin.Left * scaleY, f.Margin.Top * scaleX, 0, 0);
            }
        }

        private void onBorderResize(object sender, SizeChangedEventArgs e)
        {
            if (e.PreviousSize.Height == 0 || e.PreviousSize.Width == 0)
            {
                return;
            }
            double scaleX = e.NewSize.Height / e.PreviousSize.Height;
            double scaleY = e.NewSize.Width / e.PreviousSize.Width;
            FrameworkElement f = (sender as Border).Child as FrameworkElement;
            f.Height = f.Height * scaleX;
            f.Width = f.Width * scaleY;
            f.Margin = new Thickness(f.Margin.Left * scaleY, f.Margin.Top * scaleX, 0, 0);
        }

        private void OnMainCalendarSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = mainCalendar.SelectedDate;
            if (selectedDate.HasValue)
            {
                DateTextBlock.Text = selectedDate.Value.ToString("D", CultureInfo.GetCultureInfo("ru-RU"));
            }
        }
    }
}
