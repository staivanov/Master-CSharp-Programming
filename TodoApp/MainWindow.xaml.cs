using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainContent.Content = new LoginView();
        }


        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = TodoInput.Text;


            if (!string.IsNullOrEmpty(todoText))
            {
                TextBlock todoItem = new()
                {
                    Text = todoText,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White)
                };

                TodoList.Children.Add(todoItem);
                TodoInput.Clear();
            }
        }
    }
}