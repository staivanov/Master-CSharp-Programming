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
        }
    }
}
