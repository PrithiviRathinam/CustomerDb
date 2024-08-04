using System.Text.Json.Serialization;

namespace MongoDBEFCoreDemo
{
    public class CustomerDTO
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("designation")]
        public string? Designation { get; set; }
    }
}
