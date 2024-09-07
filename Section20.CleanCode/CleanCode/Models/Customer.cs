namespace Section20.CleanCode.Models
{
    public class Customer
    {
        /// <summary>
        /// Get Id of the Customer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get or Set name of the Customer.
        /// </summary>
        public string Name { get; set; }


        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Gets the customer by id.
        /// </summary>
        /// <param name="id">Id of the customer to be retrived</param>
        /// <returns>Return the customer found by id.</returns>
        public Customer GetCustomerById(int id)
        {
            return new Customer(Id = id, Name = "Anonynomous");
        }
    }
}
