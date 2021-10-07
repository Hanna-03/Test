using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataLib.Modell
{
    public abstract class User : IModel
    {
        [BsonId]
        [BsonElement("_id")]
        public Guid Id { get; set; }

        [BsonElement("Firstname")]
        public string Firstname { get; set; }

        [BsonElement("Lastname")]
        public string Lastname { get; set; }

        [BsonElement("Nickname")]
        public string Nickname { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

    }
}
