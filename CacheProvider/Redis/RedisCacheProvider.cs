using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;

namespace CacheProvider.Redis
{
    public class RedisCacheProvider : ICacheProvider
    {
        public void AddItem(string key, object item, int expireInMinutes)
        {
            throw new NotImplementedException();
        }

        public object GetItem(string key)
        {
            throw new NotImplementedException();
        }

        public T GetItem<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(string key)
        {
            throw new NotImplementedException();
        }
    }
}
