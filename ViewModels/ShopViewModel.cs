using OganiTask.DataAccessLayer.Entities;

namespace Ogani.ViewModels
{
    public class ShopViewModel
    {
        public List<Department> Departments { get; set; }
        public List<Color> Colors { get; set; }
        public List<Size> Sizes { get; set; }
        public List<Product> Products { get; set; }
        //public List<ShopBanner> ShopBanners { get; set; }
    }
}
