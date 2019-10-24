using CarProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarProject.Services
{
    public class DataBaseService
    {
        private IDataBase dataBase;
        private static DataBaseService instanse;

        public static DataBaseService GetInstanse(bool DBIsNull = false)
        {
            if (instanse == null)
                instanse = new DataBaseService();
            if (instanse.dataBase == null && !DBIsNull)
                throw new Exception("Please, set type of DataBase before using.");
            return instanse;
        }

        public void SetNewDataBaseType(IDataBase dataBase)
        {
            this.dataBase = dataBase;
            if (!dataBase.GetAllItems<Car>().Any())
                FillFakeData();
        }

        public List<AbstractTransport> GetAllTransports() 
        {
            var listTransport = new List<AbstractTransport>();
            listTransport.AddRange(dataBase.GetAllItems<Car>());
            return listTransport;
        }

        private void FillFakeData()
        {
            var transport = new Car()
            {
                Mark = "Toyota",
                Model = "Crown",
                Color = "White",
                Engine = "5R I4",
                Year = 2019,
                HorsePower = 245,
                TypeTransport = TransportType.Car,
                Price = 77700
            };
            transport.SaveItem();
            transport = new Car()
            {
                Mark = "BMW",
                Model = "X5",
                Color = "Black",
                Year = 2007,
                Engine = "M50d",
                HorsePower = 272,
                TypeTransport = TransportType.Car,
                Price = 11900
            };
            transport.SaveItem();
            transport = new Car()
            {
                Mark = "Nissan",
                Model = "March",
                Year = 2002,
                Color = "Grey",
                Engine = "DBA-K13",
                HorsePower = 245,
                TypeTransport = TransportType.Car,
                Price = 77700
            };
            transport.SaveItem();
        }

        public List<T> GetAllItems<T>() where T : new()
        {
            return dataBase.GetAllItems<T>();
        }

        public void RemoveAllItems<T>()
        {
            dataBase.RemoveAllItems<T>();
        }

        public void RemoveItem<T>(T item)
        {
            dataBase.RemoveItem<T>(item);
        }

        public void SaveItem<T>(T item)
        {
            dataBase.SaveItem<T>(item);
        }

        public void UpdateItem<T>(T item)
        {
            dataBase.UpdateItem<T>(item);
        }
    }
}
