
namespace CacheProvider
{
    public interface ICacheProvider
    {
        void Add(string key, object item, int expireInMinutes);

        T Get<T>(string key);

        void Remove(string key);

        void RemoveAll();
    }
}
