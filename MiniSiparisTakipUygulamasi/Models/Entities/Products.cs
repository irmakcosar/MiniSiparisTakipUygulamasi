namespace MiniSiparisTakipUygulamasi.Models.Entities

{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        // Navigation property
        public virtual Categories Category { get; set; }
    }
}
