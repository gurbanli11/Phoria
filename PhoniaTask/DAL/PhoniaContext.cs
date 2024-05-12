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
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=CLASSOSERAMICEU\\SQLEXPRESS01;DataBase=Phonia106;Trusted_Connection=true;TrustServerCertificate=True");
            base.OnConfiguring(options);
        }
        //public DbSet<PhoniaTask.ViewModels.Categories.GetCategoryVM> GetCategoryVM { get; set; } = default;
    }
}
