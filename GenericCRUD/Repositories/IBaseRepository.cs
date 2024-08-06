namespace GenericCRUD.Repositories
{
    internal interface IBaseRepository<TKey, TValue>
    {
        TValue Insert(TValue item);
        TValue GetById(TKey key);
        List<TValue> GetAll();
        List<TValue> Filter(Func<TValue, bool> predicate);
        TValue Update(TKey key, TValue item);
        TValue Delete(TKey key);
    }
}
