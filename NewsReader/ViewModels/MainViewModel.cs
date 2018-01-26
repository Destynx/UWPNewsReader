using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsReader.Model;
using NewsReader.Services;

namespace NewsReader.ViewModels
{
    sealed class MainViewModel
    {
        public static MainViewModel SingleInstance { get; } = new MainViewModel();

        private MainViewModel()
        {

        }

        public ObservableCollection<Article> ListOfObjects { get; } = new ObservableCollection<Article>();

        public async Task InitializeAsync()
        {
            RootObject list = await Backend.GetDataFromBackendAsync();
            foreach (Article item in list.Results)
            {
                ListOfObjects.Add(item);
            }
        }
    }
}
