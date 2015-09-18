using Newtonsoft.Json;

namespace DummyApp.Data.Model
{
    public class Todo
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }

}
