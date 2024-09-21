using System.Windows;
using System.Windows.Controls;

namespace WPFapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new();
            myButton.Content = "AB";
            Grid.SetRow(myButton, 3);
            Grid.SetColumn(myButton, 4);

            Grid? myGrid = FindName("myGrid") as Grid;
            myGrid.Children.Add(myButton);
        }

        /// <summary>
        /// The name of this method is a reference to attribute value in a .xaml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}