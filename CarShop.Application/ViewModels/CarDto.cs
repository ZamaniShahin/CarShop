namespace CarShop.Application.ViewModels
{
    public record CarDto
    {
        public string CarName { get; set; }
        public string CarBrand { get; set; }
        public string CarCreatedYear { get; set; }
        public string CarColor { get; set; }
        public string CarCategory { get; set; }
    }
}
