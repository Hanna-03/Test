using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataLib.Modell
{
    public abstract class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }

        [BsonElement("FirstName")]
        public string Firstname { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("BirthDate")]
        public DateTime BirthDate { get; set; }

        [BsonElement("Nickname")]
        public string Nickname { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }
        
        [BsonElement("Organisation")]
        public string Organisation { get; set; }

    }
}
