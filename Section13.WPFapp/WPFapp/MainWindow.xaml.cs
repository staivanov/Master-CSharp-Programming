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
    }
}