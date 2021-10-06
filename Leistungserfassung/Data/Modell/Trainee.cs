using MongoDB.Bson.Serialization.Attributes;

namespace DataLib.Modell
{
    public class Trainee : User
    {
        [BsonElement("Group")]
        public string Group { get; set; }

        [BsonElement("Job")]
        public string Job { get; set; }
    }
}
