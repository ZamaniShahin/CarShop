namespace CarShop.Domain.Models
{
    public class CarCategory(string categoryName)
    {
        public long Id { get; set; }
        public string CategoryName { get; set; } = categoryName;
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public void Edit(string categoryName, DateTime dateCreated)
        {
            CategoryName = categoryName;
            DateCreated = DateTime.Now;
        }
    }
}
