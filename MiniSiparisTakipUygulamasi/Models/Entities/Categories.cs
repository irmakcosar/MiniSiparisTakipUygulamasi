namespace MiniSiparisTakipUygulamasi.Models.Entities
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Products> Products { get; set; } = new List<Products>();
    }
}
