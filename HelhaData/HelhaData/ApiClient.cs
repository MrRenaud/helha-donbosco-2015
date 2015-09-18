using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelhaData
{
    public class ApiClient
    {
        public async Task<List<TodoItem>> GetTodos()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync("http://jsonplaceholder.typicode.com/todos");
                var todoItems = JsonConvert.DeserializeObject<List<TodoItem>>(result);
                Debug.WriteLine(result);

                return todoItems;
            }
        }
    }
}
