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
            string connectionString = ConfigurationManager.ConnectionStrings["ZooDbConnectionString"].ConnectionString;
            _connection = new SqlConnection(connectionString);
            ShowZoo();
            ShowAssociatedAnimals();
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
                    listZoos.DisplayMemberPath = "Location";
                    listZoos.SelectedValuePath = "Id";
                    listZoos.ItemsSource = zooTable.DefaultView;
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

        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "SELECT * FROM Animal a " +
                               "INNER JOIN ZooAnimal za " +
                               "ON a.Id = za.AnimalId" +
                               "WHERE za.ZooId = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);

                using (adapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                    DataTable zooTable = new DataTable();
                    adapter.Fill(zooTable);
                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    listAssociatedAnimals.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
            => ShowAssociatedAnimals();
    }
}
