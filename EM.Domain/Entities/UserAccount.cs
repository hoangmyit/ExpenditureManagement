using EM.Domain.Common;
using EM.Domain.Enums;

namespace EM.Domain.Entities
{
    public class UserAccount : BaseEntity
    {
        public required string Name { get; set; }
        public string? ImgUrl { get; set; }
        public double? CreditLimit { get; set; }
        public double? AvalableLimit { get; set; }
        public double Balance { get; set; }
        public DateTimeOffset? DueDate { get; set; }
        public AccountType AccountType { get; set; }
        public int Order { get; set; }
        public bool IsDelete { get; set; }
    }
}
