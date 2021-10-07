using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Test : IModel
    {
        [BsonId]
        [BsonElement("Id")]
        public Guid Id { get; set; }

        [BsonElement("Thema")]
        public string Thema { get; set; }

        [BsonElement("InstructorId")]
        public Guid InstructorId { get; set; }

        [BsonElement("QuestionIds")]
        public List<Guid> QuestionIds { get; set; }

        [BsonElement("CourseId")]
        public Guid CourseId { get; set; }

        [BsonElement("MaxPoints")]
        public double MaxPoints { get; set; }
    }
}
