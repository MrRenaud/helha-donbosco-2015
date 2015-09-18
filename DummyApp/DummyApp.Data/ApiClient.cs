using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DummyApp.Data.Model;
using Newtonsoft.Json;

namespace DummyApp.Data
{
    public class ApiClient
    {
        public async Task<List<Todo>> GetTodos()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(new Uri("http://jsonplaceholder.typicode.com/todos/", UriKind.Absolute));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    List<Todo> todos = JsonConvert.DeserializeObject<List<Todo>>(content);
                    return todos;
                }
            }
            return default(List<Todo>);
        }
    }
}
