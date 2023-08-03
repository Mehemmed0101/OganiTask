
using OganiTask.DataAccessLayer.Entities;

namespace Ogani.ViewModels
{
    public class HomeViewModel
    {
        public List<Department> Departments { get; set; }
        public List<Category> Categories { get; set; }
        public List<Filter> Filters { get; set; }
        public List<Product> Products { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<HomeTopBanner> HomeTopBanners { get; set; }
    }
}
