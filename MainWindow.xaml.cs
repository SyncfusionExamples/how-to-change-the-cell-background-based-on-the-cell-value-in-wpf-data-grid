using System;
using System.Data;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace SfDataGridDemo
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
    }

    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Get the DataRowView
            var dataRow = value as DataRowView;

            //Get the colors name value
            var record = dataRow.Row["Colors"].ToString();

            //You can use a BrushConverter
            SolidColorBrush redBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(record);

            //return the color based on DataBase cell value
            return redBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
