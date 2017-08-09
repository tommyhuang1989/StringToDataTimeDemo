using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

namespace DateTimeParseExcatDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb.Text))
                return;

            String result = String.Empty;
            try
            {
                //DaInfFile.DriverDate = DateTime.Parse(DriverVer[0], cultrueInfo).ToString("yyyy-MM-dd");
                DateTime dt = DateTime.ParseExact(tb.Text, "M/d/yyyy",  CultureInfo.InvariantCulture);//.ToString("yyyy-MM-dd");
                tbk2.Text = "ParseExact is:" + dt.ToString("yyyy-MM-dd");
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb.Text))
                return;

            String result = String.Empty;
            try
            {
                //DateTime dt = DateTime.Parse(tb.Text, CultureInfo.CreateSpecificCulture("en-US"));
                DateTime dt = DateTime.Parse(tb.Text, CultureInfo.InvariantCulture);//.ToString
                //("yyyy-MM-dd");
                tbk1.Text = "Parse is:" + dt.ToString("yyyy-MM-dd");
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb.Text))
                return;

            String result = String.Empty;
            try
            {
                //DateTime dt = DateTime.Parse(tb.Text, CultureInfo.CreateSpecificCulture("en-US"));
                DateTime dt = Convert.ToDateTime(tb.Text, CultureInfo.InvariantCulture);//.ToString
                //("yyyy-MM-dd");
                tbk3.Text = "Convert is:" + dt.ToString("yyyy-MM-dd");
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}
