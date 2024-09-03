using System.Configuration;
using System.Windows;

namespace Section10.LinqToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LinqToSqlDataClassesDataContext _dataContext;

        public MainWindow()
        {
            InitializeComponent();
            string connectionStringName = "Section10.LinqToSql.Properties.Settings.ZooDbConnectionString";
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            _dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            InsertUniversity(new University() { Name = "Yale" });
            DisplayOnDataTable();
        }


        private void InsertUniversity(University university)
        {
            University newUni = new University()
            {
                Name = university.Name
            };

            _dataContext.Universities.InsertOnSubmit(newUni);
            _dataContext.SubmitChanges();
        }

        private void DisplayOnDataTable()
        {
            MainDataGrid.ItemsSource = _dataContext.Universities;
        }
    }
}
