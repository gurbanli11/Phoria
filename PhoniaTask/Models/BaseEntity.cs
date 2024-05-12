namespace PhoniaTask.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreateTime { get; set; }
    }
}
