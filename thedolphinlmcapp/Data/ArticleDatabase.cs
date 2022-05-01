using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using thedolphinlmcapp.Models;

namespace thedolphinlmcapp.Data
{
    public class ArticleDatabase
    {
        public SQLiteAsyncConnection database;

        public ArticleDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Article>().Wait();
        }

        public Task<List<Article>> GetArticleAsync()
        {
            //Get all articles.
            return database.Table<Article>().ToListAsync();
        }

        public Task<Article> GetArticleAsync(int id)
        {
            // Get a specific article.
            return database.Table<Article>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveArticleAsync(Article article)
        {
            if (article.ID != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(article);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(article);
            }
        }

        public Task<int> DeleteArticleAsync(Article article)
        {
            // Delete a note.
            return database.DeleteAsync(article);
        }
    }
}