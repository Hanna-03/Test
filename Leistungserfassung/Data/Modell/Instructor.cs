using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DataLib.Modell
{
    public class Instructor: User
    {
        [BsonElement("Courses")]
        public List<int> Courses { get; set; }
    }
}
