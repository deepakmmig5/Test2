using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Test2.Models;

public class Users
{

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Id")]
 public string UserID { get; set; }

 public string Username { get; set; }

 public string FullName { get; set; }

 public DateTime CreatedDate { get; set; }

}
