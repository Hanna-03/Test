using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Question
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }

        [BsonElement("Quelle")]
        public string Quelle { get; set; }

        [BsonElement("TeacherId")]
        public Guid TeacherId { get; set; }

        [BsonElement("ClassesIds")]
        public List<Guid> ClassesIds { get; set; }

        [BsonElement("FalseAnswers")]
        public List<string> FalseAnswers { get; set; }

        [BsonElement("TrueAnswers")]
        public List<string> TrueAnswers { get; set; }

        [BsonElement("Category")]
        public int Category { get; set; }

        [BsonElement("AnswerMode")]
        public int AnswerMode { get; set; }

        [BsonElement("CourseId")]
        public Guid CourseId { get; set; }

    }
}
