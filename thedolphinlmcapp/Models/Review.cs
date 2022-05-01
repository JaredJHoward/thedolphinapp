using System;
using SQLite;

namespace thedolphinlmcapp.Models
{
    public class Review
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public string ArticleName { get; set; }
        public DateTime Date { get; set; }
    }
}