using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LogisticApp.Models
{
    public class Client
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}