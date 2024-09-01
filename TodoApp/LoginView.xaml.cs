using System.Windows;
using System.Windows.Controls;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new InvoiceView();

        }
    }
}
