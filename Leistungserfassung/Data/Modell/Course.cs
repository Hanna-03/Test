using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Course : IModel
    {
        [BsonId]
        [BsonElement("_id")]
        public Guid Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("InstructorIds")]
        public List<Guid> InstructorIds { get; set; }
        
        [BsonElement("ClassIds")]
        public List<Guid> ClassIds { get; set; }
    }
}
