namespace Section20.CleanCode.Services
{   //PascalCase

    /// <summary>
    /// Represent Customer Service
    /// </summary>
    public class CustomerService
    {
        private string _lastCutomerName; //CamelCase
        //CamelCase (without_ is also valid for private fields)
        private string customerName;
        public int CustomerCount { get; set; } //PascalCase

        // TODO: Implement SaveCustomerName method.
        public void SaveCustomerName()
        {

        }

    }
}
