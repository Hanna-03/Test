using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DataLib.Modell
{
    public class Trainee : User
    {
        [BsonElement("ClassId")]
        public Guid ClassId { get; set; }
    }
}
