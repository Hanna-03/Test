using DataLib.Modell;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Leistungserfassung.Service
{
    public class DBService<T> where T : IModel
    {

        private readonly IMongoCollection<T> _collection;

        public DBService()
        {
            var client = new MongoClient(Statics.ConnectionString);
            var database = client.GetDatabase(Statics.DatabaseName);

            _collection = database.GetCollection<T>(Statics.GetCollectionString(typeof(T).Name));
        }


        public List<T> Get() =>
            _collection.Find(_obj => true).ToList();

        public T Get(Guid id) =>
            _collection.Find<T>(_obj => _obj.Id == id).FirstOrDefault();

        public T Create(T _obj)
        {
            _collection.InsertOne(_obj);
            return _obj;
        }

        public void Update(Guid id, T objIn) =>
            _collection.ReplaceOne(_obj => _obj.Id == id, objIn);

        public void Remove(T objIn) =>
            _collection.DeleteOne(book => book.Id == objIn.Id);

        public void Remove(Guid id) =>
            _collection.DeleteOne(_obj => _obj.Id == id);
    }
}
