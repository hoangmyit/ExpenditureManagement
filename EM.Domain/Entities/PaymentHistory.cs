using EM.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace EM.Domain.Entities
{
    public class PaymentHistory : BaseEntity
    {
        public Guid CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public Guid AccountId { get; set; }
        public double Amount { get; set; }
        public bool IsReceive { get; set; }
        public string? Description { get; set; }
        public required string Title { get; set; }
    }
}
