using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WPFZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SqlConnection _connection = new SqlConnection();

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["WPFZooManager.Properties.Settings.ZooDbConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            ShowZoo();
        }


        private void ShowZoo()
        {
            string query = "SELECT * FROM Zoo";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, _connection);

            using (sqlDataAdapter)
            {
                try
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    ListZoos.DisplayMemberPath = "Location";
                    ListZoos.SelectedValuePath = "Id";
                    ListZoos.ItemsSource = zooTable.DefaultView;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }


            void listZoos_SelectionChanged(object sender, SelectedCellsChangedEventArgs e)
            {
                MessageBox.Show("Listzoos was clicked.");
            }
        }
    }
}
