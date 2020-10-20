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
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(
            string category,
            ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2019.jpg" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2019.jpg" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2019.jpg" });
            items.Add(new NewsItem() { Id = 4, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2019.jpg" });
            items.Add(new NewsItem() { Id = 5, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2019.jpg" });
            items.Add(new NewsItem() { Id = 6, Category = "Financial", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2019.jpg" });

            items.Add(new NewsItem() { Id = 7, Category = "Food", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2018.jpg" });
            items.Add(new NewsItem() { Id = 8, Category = "Food", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2018.jpg" });
            items.Add(new NewsItem() { Id = 9, Category = "Food", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2018.jpg" });
            items.Add(new NewsItem() { Id = 10, Category = "Food", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2018.jpg" });
            items.Add(new NewsItem() { Id = 11, Category = "Food", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2018.jpg" });
            items.Add(new NewsItem() { Id = 12, Category = "Food", Headline = "Abc", Subhead = "Xyz", DateLine = "123", Image = "Assets/neo-2018.jpg" });

            return items;
        }
    }
}
