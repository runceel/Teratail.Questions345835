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

        private void ShowAnotherWindowButton_Click(object sender, RoutedEventArgs e)
        {
            new AnotherWindow().Show();
        }
    }
}
