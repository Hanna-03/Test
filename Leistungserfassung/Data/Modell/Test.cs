using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Test
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }

        [BsonElement("Thema")]
        public string Thema { get; set; }

        [BsonElement("TeacherId")]
        public Guid TeacherId { get; set; }

        [BsonElement("QuestionsIds")]
        public List<Guid> QuestionsIds { get; set; }

        [BsonElement("CourseId")]
        public Guid CourseId { get; set; }
    }
}
