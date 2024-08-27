using System.Windows;
using System.Windows.Controls;

namespace WpfApp
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
            myButton.Content = "B";
            Grid.SetRow(myButton, 3);
            Grid.SetColumn(myButton, 4);
            Grid myGrid = (Grid)FindName("myGrid");
            myGrid.Children.Add(myButton);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
            => MessageBox.Show("Hello World");
    }
}