using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Class : IModel
    {
        [BsonId]
        [BsonElement("Id")]
        public Guid Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Trainees")]
        public List<Guid> Trainees { get; set; }

        [BsonElement("ClassTeacher")]
        public Guid ClassTeacher { get; set; }
    }
}
