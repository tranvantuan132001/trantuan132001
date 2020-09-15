using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using javax.script;
using lap08.Model;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.System;
using Windows.UI.Xaml.Controls;

namespace lap08.Model
{

    public sealed partial class NewsItemControl : UserControl
    {
        public Model.NewsItem NewsItem { get { return this.DataContext as Model.NewsItem; } }
        public NewsItemControl()
        {
            this.InitializeComponent();
            this.DataContextChanged += (s, e) => Bindings,Update();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }

    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }
    }
   
    public class NewsManger
    {
        public static void GetNews(string category,
            ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));

        }
    
        public static List<NewsItem> GetNewsItems()
        {
            
            var item = new List<NewsItem>();
            item.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Địa ngục trần gian" });
            item.Add(new NewsItem() { Id = 2, Category = "Financial", Headline = "đây là sách không hay" });
            item.Add(new NewsItem() { Id = 3, Category = "Financial", Headline = "đây là sách có hay" });
            item.Add(new NewsItem() { Id = 4, Category = "Financial", Headline = "đây là sách ma " });
            item.Add(new NewsItem() { Id = 5, Category = "Financial", Headline = "đây là sách kinh dị" });

            item.Add(new NewsItem() { Id = 6, Category = "Food", Headline = "đây là sách kinh dị" });
            item.Add(new NewsItem() { Id = 7, Category = "Food", Headline = "rảnh thì chơi" });
            item.Add(new NewsItem() { Id = 8, Category = "Food", Headline = "không rảnh cũng chơi" });
            item.Add(new NewsItem() { Id = 9, Category = "Food", Headline = "đây là sách kinh dị" });
            item.Add(new NewsItem() { Id = 10, Category = "Food", Headline = "cấm trẻ em ăn nhiều" });


            return item;
        }
    }
}
