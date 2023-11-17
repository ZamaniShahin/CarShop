namespace CarShop.Domain.Models
{
    public class CarCategory(string categoryName)
    {
        public long Id { get; set; }
        public string CategoryName { get; set; } = categoryName;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public List<Car> Cars { get; set; }

        public void Edit(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
