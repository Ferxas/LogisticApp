using MongoDb.Bson;
using MongoDb.Bson.Serialization.Attributes;

namespace LogisticApp.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}