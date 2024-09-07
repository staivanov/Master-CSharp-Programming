using Section21.Generics.Interfaces;

namespace Section21.Generics
{
    public class Box<T> where T : IEntity
    {
        private List<T> values = new List<T>();

        public void Add(T entity)
            => values.Add(entity);




    }
}
