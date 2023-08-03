namespace OganiTask.DataAccessLayer.Entities
{
    public class Filter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DataFilter { get; set; }
        public List<Product> Products { get; set; }
    }
}
