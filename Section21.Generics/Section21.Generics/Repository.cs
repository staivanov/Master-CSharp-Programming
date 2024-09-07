namespace Section21.Generics
{
    public class Repository<T>
    {
        private List<T> values = new List<T>();

        public void Add(T entity)
            => values.Add(entity);

        public void Remove(T entity)
            => values.Remove(entity);
    }
}
