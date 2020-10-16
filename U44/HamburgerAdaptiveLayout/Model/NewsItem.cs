using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerAdaptiveLayout.Model
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DataLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(
            string category,
            ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DataLine = "123", Image = "Assets/neo-cartoon.jpg" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DataLine = "123", Image = "Assets/neo-cartoon.jpg" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DataLine = "123", Image = "Assets/neo-cartoon.jpg" });

            items.Add(new NewsItem() { Id = 4, Category = "Food", Headline = "Abc", Subhead = "Xyz", DataLine = "123", Image = "Assets/neo-2018.jpg" });
            items.Add(new NewsItem() { Id = 5, Category = "Food", Headline = "Abc", Subhead = "Xyz", DataLine = "123", Image = "Assets/neo-2018.jpg" });
            items.Add(new NewsItem() { Id = 6, Category = "Food", Headline = "Abc", Subhead = "Xyz", DataLine = "123", Image = "Assets/neo-2018.jpg" });

            return items;
        }
    }
}
