using System.Collections;
using System.Windows;
using System.Windows.Controls;
using WPFdemo.Data;

namespace WPFdemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> _people = new()
        {
            new Person { Age = 18, Name = "Peter"},
            new Person { Age = 30, Name = "Jax"},
            new Person {Age = 42, Name = "Angie"},
        };

        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = _people;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            IList selectedItems = ListBoxPeople.SelectedItems;

            foreach (object item in selectedItems)
            {
                Person? person = item as Person;
                MessageBox.Show(person?.Name);
                MessageBox.Show(person?.Age.ToString());
            }

        }
    }
}