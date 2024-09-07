﻿namespace Section21.Generics.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        void Remove(T entity);
    }
}
