using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

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

            Student vasko = new Student()
            {
                Name = "Vasko",
                Gender = "Male"
            };
            string oxford = "University of Oxford";

            //InsertStudent(vasko, oxford);
            DisplayStudentsOnDataTable();
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


        private void InsertStudent(Student newStudent, string universityName)
        {
            University uni = _dataContext
                .Universities
                .FirstOrDefault(u => u.Name == universityName);

            newStudent.UniversityId = uni.Id;
            newStudent.University = uni;

            _dataContext.Students.InsertOnSubmit(newStudent);
            _dataContext.SubmitChanges();
        }

        private void DisplayUniversitiesOnDataTable()
            => MainDataGrid.ItemsSource = _dataContext.Universities;

        private void DisplayStudentsOnDataTable()
            => MainDataGrid.ItemsSource = _dataContext.Students;
    }
}
