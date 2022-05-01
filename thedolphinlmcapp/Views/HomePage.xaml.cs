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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            webView.Source = "https://thedolphinlmc.com/category/news-features/";
        }
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            //todo
            //add code so that article name is displayed in database
            //add code so link does add function 
            //if (e.Url.StartsWith("xxx"))
            //{
                //e.Cancel = true;
            //}
            
        }
        async void OnAddClicked(object sender, EventArgs e)
        {
            // Navigate to the NoteEntryPage.
            await Shell.Current.GoToAsync(nameof(ArticleEntryPage));
        }
    }
}