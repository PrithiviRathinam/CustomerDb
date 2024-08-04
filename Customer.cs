using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;

namespace MongoDBEFCoreDemo
{
    [Collection("customer")]
    public class Customer
    {
        public ObjectId Id { get; set; } 

        public string? Name { get; set; }

        public string? Designation { get; set; }
    }
}
