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

        [BsonElement("TraineeIds")]
        public List<Guid> TraineeIds { get; set; }

        [BsonElement("ClassInstructorId")]
        public Guid ClassInstructorId { get; set; }

        [BsonElement("CourseIds")]
        public List<Guid> CourseIds { get; set; }
    }
}
