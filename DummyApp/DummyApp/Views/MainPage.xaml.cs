using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DummyApp.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DummyApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContextChanged += (sender, args) => { ViewModel = (MainViewModel)DataContext; };
            this.Loaded += async (sender, args) => await ViewModel.LoadData();
        }

        public MainViewModel ViewModel { get; set; }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
