using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarProject.Services
{
    public class DataBaseSQL : IDataBase
    {
        private string dbPath;

        protected SQLiteConnection GetConnection()
        {
            var platform = new SQLite.Net.Platform.Win32.SQLitePlatformWin32();
            var connection = new SQLiteConnection(platform, "DataBase.db");
            connection.BusyTimeout = new TimeSpan(0, 0, 3);
            return connection;
        }

        public List<T> GetAllItems<T>() where T : new()
        {
            List<T> sync = new List<T>();
            try
            {
                SQLiteConnection connection = GetConnection();
                var table = connection.Table<T>();
                return table.ToList();
            }
            catch
            {
                return sync;
            }
        }

        public void SaveItem<T>(T item)
        {
            SQLiteConnection connection = GetConnection();
            connection.CreateTable<T>();
            connection.Insert(item);
        }

        public void RemoveItem<T>(T item)
        {
            SQLiteConnection connection = GetConnection();
            connection.CreateTable<T>();
            connection.Delete(item);
        }

        public void RemoveAllItems<T>()
        {
            SQLiteConnection connection = GetConnection();
            connection.DropTable<T>();
        }

        public void UpdateItem<T>(T item)
        {
            SQLiteConnection connection = GetConnection();
            connection.CreateTable<T>();
            connection.Update(item);
        }
    }
}
