using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Helha.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public MainViewModel()
        {
            HelloMessage = "Hello from DataBinding";
            TodoItems = new List<TodoItem>();

            for (int i = 0; i < 10; i++)
            {
                TodoItems.Add(new TodoItem() { IsDone = i % 2 == 0, Title = "Task #" + i });
            }
        }

        private string _helloMessage;
        public string HelloMessage
        {
            get { return _helloMessage; }
            set
            {
                _helloMessage = value;
                OnPropertyChanged();
            }
        }

        public List<TodoItem> TodoItems { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
