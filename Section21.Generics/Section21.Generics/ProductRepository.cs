using Section21.Generics.Interfaces;

namespace Section21.Generics
{
    public class ProductRepository : IRepository<Product>
    {
        void IRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Product>.Remove(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
