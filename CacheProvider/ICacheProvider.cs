
namespace CacheProvider
{
    public interface ICacheProvider
    {
        void AddItem(string key, object item, int expireInMinutes);

        object GetItem(string key);

        T GetItem<T>(string key);

        void RemoveItem(string key);

        void RemoveAll();
    }
}
