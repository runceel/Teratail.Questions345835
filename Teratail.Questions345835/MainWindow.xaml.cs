using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Teratail.Questions345835
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

        private void BordColorC2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pair = (KeyValuePair<string, SolidColorBrush>)BordColorC2.SelectedItem;
            Rectan2.Stroke = pair.Value;
        }
    }
}
