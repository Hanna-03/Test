using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Result : IModel
    {
        [BsonId]
        [BsonElement("Id")]
        public Guid Id { get; set; }

        [BsonElement("TestId")]
        public Guid TestId { get; set; }

        [BsonElement("InstructorId")]
        public Guid InstructorId { get; set; }

        [BsonElement("TraineeId")]
        public Guid TraineeId { get; set; }

        [BsonElement("Points")]
        public double Points { get; set; }

        [BsonElement("MaxPoints")]
        public double MaxPoints { get; set; }
    }
}
