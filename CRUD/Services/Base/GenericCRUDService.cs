namespace CRUD.Services.Base
{
    internal class GenericCRUDService<T> : IGenericCRUDService<T> where T : class
    {
        private List<T> items;

        public GenericCRUDService()
            => items = new List<T>();

        public void Create(T item, Action<T> callback = null)
        {
            items.Add(item);
            callback?.Invoke(item);
        }

        public bool Delete(Func<T, bool> predicate, Action<T> callback = null)
        {
            var item = items.FirstOrDefault(predicate);

            if (item is not null)
            {
                items.Remove(item);
                callback?.Invoke(item);
                return true;
            }

            return false;
        }

        public List<T> Filter(Func<T, bool> predicate, Action<IEnumerable<T>> callback = null)
        {
            var filteredItems = items.Where(predicate).ToList();
            callback?.Invoke(filteredItems);
            return filteredItems;
        }

        public List<T> ListAll(Action<IEnumerable<T>> callback = null)
        {
            callback?.Invoke(items);
            return items;
        }

        public T Read(Func<T, bool> predicate, Action<T> callback = null)
        {
            var item = items.FirstOrDefault(predicate);
            callback?.Invoke(item);
            return item;
        }

        public bool Update(Func<T, bool> predicate, T newItem, Action<T> callback = null)
        {
            var item = items.FirstOrDefault(predicate);
            if (item is not null)
            {
                item = newItem;
                callback?.Invoke(newItem);
                return true;
            }
            return false;
        }
    }
}
