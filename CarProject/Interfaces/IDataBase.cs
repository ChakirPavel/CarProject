using System.Collections.Generic;

namespace CarProject.Services
{
    public interface IDataBase
    {
        List<T> GetAllItems<T>() where T : new();
        void SaveItem<T>(T item);
        void RemoveItem<T>(T item);
        void RemoveAllItems<T>();
        void UpdateItem<T>(T item);
    }
}
