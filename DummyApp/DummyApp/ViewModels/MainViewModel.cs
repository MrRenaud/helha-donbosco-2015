using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyApp.Data;
using DummyApp.Data.Model;

namespace DummyApp.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Todos = new ObservableCollection<Todo>();
        }

        public async Task LoadData()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                Todos.Add(new Todo() { completed = true, id = 1, title = "My first todo", UserId = 1 });
                Todos.Add(new Todo() { completed = true, id = 1, title = "My first todo", UserId = 1 });
                Todos.Add(new Todo() { completed = true, id = 1, title = "My first todo", UserId = 1 });
                Todos.Add(new Todo() { completed = true, id = 1, title = "My first todo", UserId = 1 });
            }
            else
            {
                var apiClient = new ApiClient();
                var todos = await apiClient.GetTodos();
                todos.ForEach(t => Todos.Add(t));
            }
        }

        public ObservableCollection<Todo> Todos { get; set; }
    }
}
