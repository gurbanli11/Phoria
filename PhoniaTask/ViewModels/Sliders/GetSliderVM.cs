using System.ComponentModel.DataAnnotations;

namespace PhoniaTask.ViewModels.Sliders
{
    public class GetSliderVM
    {
        public int Id { get; set; }
        [MaxLength(32, ErrorMessage = "Basliq 32 simvoldan cox olmamalidir"), Required]
        public string Title { get; set; }
        [Range(0, 100)]
        public int Discount { get; set; }
        [MaxLength(64), Required]
        public string Subtitle { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
