namespace ControleDeDespesas.Models.Base
{
    public abstract class ModelBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool Deleted { get; set; }
    }
}