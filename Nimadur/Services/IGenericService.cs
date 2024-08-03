namespace Nimadur.Services
{
    interface IGenericService<T>
    {
        void Add(T entity, Action<T> action = null);
        void DeleteById(Func<T, bool> func, Action<T> action = null);
        T Get(Func<T, bool> func, Action<T> action = null);
        List<T> Filter(Func<T, bool> func, Action<IEnumerable<T>> action = null);
        List<T> GetAll(Action<T> action = null);
    }
}
