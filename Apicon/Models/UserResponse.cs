namespace Apicon.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    

    public class UserResponse
    {
        public bool status { get; set; }
        public string message { get; set; }
        public User data { get; set; }
    }


}
