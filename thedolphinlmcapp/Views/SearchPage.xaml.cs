using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thedolphinlmcapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        List<string> Links = new List<string>
        {
           "Link 1",
           "Link 2",
           "Link 3",
           "Link 4",
           "Link 5"
        };
        public SearchPage()
        {
            InitializeComponent();
            MainListView.ItemsSource = Links;
        }
        void OnBtnPressed(object sender, EventArgs ea)
        {
            var keyword = MainSearchBar.Text;
            MainListView.ItemsSource =
                Links.Where(name => name.ToLower().Contains(keyword.ToLower()));
        }
    }
}