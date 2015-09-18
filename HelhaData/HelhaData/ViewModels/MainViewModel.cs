using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelhaData.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region properties 

        private List<TodoItem> _todoItems;
        public List<TodoItem> TodoItems
        {
            get { return _todoItems; }
            set
            {
                _todoItems = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region ctor

        public MainViewModel()
        {
            //TodoItems = new List<TodoItem>();
        }

        #endregion

        #region events

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        #endregion

    }
}
