namespace EM.Domain.Common
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTimeOffset Created { get; set; }
        public Guid CreatedBy { get; set;}
        public DateTimeOffset? Modified { get; set; }
        public Guid? ModifiedBy { get; private set; }
    }
}
