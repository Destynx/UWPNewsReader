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

    class DetailsPageViewModel
    {
        public static DetailsPageViewModel SingleInstance { get; } = new DetailsPageViewModel();
        public Article Article;
        private DetailsPageViewModel()
        {

        }

        public void GetArticle(Article z)
        {
         Article =  z;
        }


    }
}
