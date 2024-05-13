using Microsoft.EntityFrameworkCore;
using PhoniaTask.Models;

namespace PhoniaTask.DAL
{
    public class PhoniaContext : DbContext
    {
        public PhoniaContext(DbContextOptions options) :base(options)
        { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<ProductImage>ProductImages { get; set; }
        public DbSet<Product>Products { get; set; }
        //public DbSet<PhoniaTask.ViewModels.Categories.GetCategoryVM> GetCategoryVM { get; set; } = default;
    }
}
