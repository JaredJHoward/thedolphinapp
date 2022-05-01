using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using thedolphinlmcapp.Views;

namespace thedolphinlmcapp
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            //This allows stack navigation to pages below
            Routing.RegisterRoute(nameof(ArticleEntryPage), typeof(ArticleEntryPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }
    }
}
