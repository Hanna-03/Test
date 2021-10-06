using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Results
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }

        [BsonElement("TestId")]
        public Guid TestId { get; set; }

        [BsonElement("TeacherId")]
        public Guid TeacherId { get; set; }

        [BsonElement("TraineeId")]
        public Guid TraineeId { get; set; }

        [BsonElement("Mark")]
        public double Mark { get; set; }

        [BsonElement("Comments")]
        public List<string> Comments { get; set; }
    }
}
