using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Question : IModel
    {
        [BsonId]
        [BsonElement("Id")]
        public Guid Id { get; set; }

        [BsonElement("Quelle")]
        public string Quelle { get; set; }

        [BsonElement("TeacherId")]
        public Guid TeacherId { get; set; }

        [BsonElement("ClassIds")]
        public List<Guid> ClassIds { get; set; }

        [BsonElement("FalseAnswers")]
        public List<string> FalseAnswers { get; set; }

        [BsonElement("TrueAnswers")]
        public List<string> TrueAnswers { get; set; }

        [BsonElement("Category")]
        public string Category { get; set; }

        [BsonElement("CourseId")]
        public Guid CourseId { get; set; }

        [BsonElement("Points")]
        public double Points { get; set; }

    }
}
