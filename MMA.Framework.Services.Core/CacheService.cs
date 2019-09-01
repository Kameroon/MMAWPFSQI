using MMA.Framework.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Services.Core
{
    public class CacheService : ICacheService
    {
        #region Properties

        private Dictionary<Type, List<object>> Caches { get; } = new Dictionary<Type, List<object>>();

        #endregion

        #region Methods

        public void AddCache<T>(IEnumerable<T> items = null)
            where T : class
        {
            var type = typeof(T);

            if (Caches.ContainsKey(type))
            {
                Caches[type] = new List<object>();
            }
            else
            {
                Caches.Add(type, new List<object>());
            }

            if (items != null)
            {
                Caches[type].AddRange(items);
            }
        }

        public void DeleteCache<T>() where T : class
        {
            var type = typeof(T);
            Caches.Remove(type);
        }

        public void FlushCache<T>()
            where T : class
        {
            var type = typeof(T);

            if (Caches.ContainsKey(type))
            {
                Caches[type].Clear();
            }
        }

        public IEnumerable<T> GetCache<T>()
            where T : class
        {
            var type = typeof(T);

            if (Caches.ContainsKey(type))
            {
                return Caches[type].Cast<T>();
            }

            return null;
        }

        //public TEntity GetEntity<TEntity>(int id)
        //    where TEntity : class, IEntity
        //{
        //    var entities = GetCache<TEntity>();

        //    return entities?.SingleOrDefault(e => e.Id == id);
        //}

        #endregion
    }
}