using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Instructor: User
    {
        [BsonElement("CourseIds")]
        public List<Guid> CourseIds { get; set; }

        [BsonElement("ClasseIds")]
        public List<Guid> ClasseIds { get; set; }
    }
}
