namespace NLayer.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CrearedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
