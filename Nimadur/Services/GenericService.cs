namespace Nimadur.Services
{
    class GenricService<T> : IGenericService<T>
    {
        private List<T> _entities;

        public GenricService()
        {
            _entities = new List<T>();
        }
        public void Add(T entity, Action<T> action = null)
        {
            _entities.Add(entity);
            action?.Invoke(entity);
        }

        public void DeleteById(Func<T, bool> func, Action<T> action = null)
        {
            var result = _entities.FirstOrDefault(func);

            if (result is not null)
            {
                _entities.Remove(result);
                action?.Invoke(result);
            }
        }

        public List<T> Filter(Func<T, bool> func, Action<IEnumerable<T>> action = null)
        {
            var filtered = _entities.Where(func);

            if (action is not null)
                action.Invoke(filtered);
            return filtered.ToList();
        }

        public T Get(Func<T, bool> func, Action<T> action = null)
        {
            var result = _entities.FirstOrDefault(func);
            action.Invoke(result);

            return result;
        }

        public List<T> GetAll(Action<T> action = null)
        {
            return _entities;
        }
    }

}
