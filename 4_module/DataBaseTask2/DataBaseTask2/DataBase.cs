using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTask2
{
    class DataBase
    {
        private readonly IDictionary<Type, object> _tables = new Dictionary<Type, object>();

        public string Name { get; }

        public DataBase(string name)
        {
            Name = name;
        }

        public void CreateTable<T>() where T : IEntity
        {
            Type tableType = typeof(T);

            if (_tables.ContainsKey(tableType))
                throw new DataBaseException($"Table already exists {tableType.Name}!");

            _tables[tableType] = new List<T>();
        }

        public void InsertInto<T>(IEntityFactory<T> values) where T : IEntity
        {
            Type tableType = typeof(T);

            if (!_tables.ContainsKey(tableType))
                throw new DataBaseException($"Unknown table {tableType.Name}!");

            ((List<T>)_tables[tableType]).Add(values.Instance);
        }

        public IEnumerable<T> Table<T>() where T : IEntity
        {
            Type tableType = typeof(T);

            if (!_tables.ContainsKey(tableType))
                throw new DataBaseException($"Unknown table {tableType.Name}!");

            return (IEnumerable<T>)_tables[tableType];
        }
        public void SaveDataBase<T>() where T : IEntity
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T[]));

            using (FileStream fs = new FileStream($"DB{typeof(T)}.json", FileMode.Create))
            {
                serializer.WriteObject(fs, Table<T>().ToArray());
            }
        }
        public void Deserialize<T>()where T : IEntity
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T[]));

            using (FileStream fs = new FileStream($"DB{typeof(T)}.json", FileMode.OpenOrCreate))
            {
                if (_tables.ContainsKey(typeof(T)))
                    _tables[typeof(T)] = serializer.ReadObject(fs);
                else
                {
                    _tables.Add(typeof(T), serializer.ReadObject(fs));
                }
            }
        }
    }
}
