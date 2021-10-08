using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Instructor: User
    {
        [BsonElement("CourseIds")]
        public List<Guid> CourseIds { get; set; }

        [BsonElement("ClassIds")]
        public List<Guid> ClassIds { get; set; }
    }
}
