using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Windows;


namespace WPFTasks
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



        private void MyButton_Click_1(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}.");
            HttpClient webClient = new HttpClient();
            string website = "https://google.com";
            string html = webClient.GetStringAsync(website).Result;
            MyButton.Content = "Done";
        }
    }
}
