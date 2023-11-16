namespace CarShop.Domain.Models
{
    public class Car(string carName,string carBrand, string carCreatedYear, string carColor)
    {
        public long CarId { get; set; }
        public string CarName { get; set; } = carName;
        public string CarBrand { get; set; } = carBrand;
        public string CarCreatedYear { get; set; } = carCreatedYear;
        public string CarColor { get; set; } = carColor;
        public string DateCarCreatedBanner { get; set; } = DateTime.Now.ToString();
    }
}
