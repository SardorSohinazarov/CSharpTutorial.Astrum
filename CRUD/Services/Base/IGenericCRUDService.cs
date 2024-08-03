namespace CRUD.Services.Base
{
    internal interface IGenericCRUDService<T> where T : class
    {
        void Create(T item, Action<T> callback = null);
        T Read(Func<T, bool> predicate, Action<T> callback = null);
        bool Update(Func<T, bool> predicate, T newItem, Action<T> callback = null);
        bool Delete(Func<T, bool> predicate, Action<T> callback = null);
        List<T> ListAll(Action<IEnumerable<T>> callback = null);
        List<T> Filter(Func<T, bool> predicate, Action<IEnumerable<T>> callback = null);
    }
}
