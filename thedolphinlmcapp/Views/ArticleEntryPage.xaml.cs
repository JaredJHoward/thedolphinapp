using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using thedolphinlmcapp.Models;

namespace thedolphinlmcapp.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class ArticleEntryPage : ContentPage
    {
        public string ItemId
        {
            set
            {
                LoadNote(value);
            }
        }

        public ArticleEntryPage()
        {
            InitializeComponent();

            // Set the BindingContext of the page to a new Note.
            BindingContext = new Article();
        }

        async void LoadNote(string itemId)
        {
            try
            {
                int id = Convert.ToInt32(itemId);
                // Retrieve the note and set it as the BindingContext of the page.
                Article article = await App.Database.GetArticleAsync(id);
                BindingContext = article;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load note.");
            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var article = (Article)BindingContext;
            article.Date = DateTime.UtcNow;
            if (!string.IsNullOrWhiteSpace(article.Text) || !string.IsNullOrWhiteSpace(article.ArticleName))
            {
                await App.Database.SaveArticleAsync(article);
            }
            

            // Navigate backwards
            await Shell.Current.GoToAsync("..");
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var article = (Article)BindingContext;
            await App.Database.DeleteArticleAsync(article);

            // Navigate backwards
            await Shell.Current.GoToAsync("..");
        }
    }
}