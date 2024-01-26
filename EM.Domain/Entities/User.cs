using EM.Domain.Common;
using EM.Domain.Enums;

namespace EM.Domain.Entities
{
    public class User : BaseAuditableEntity
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? Address { get; set; }
        public string? ImgUrl { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public bool IsDelete { get; set; }
        public CreatedType CreatedType { get; set; }

        public ICollection<UserAccount> AccountList { get; set; }
        public ICollection<PaymentHistory> PaymentHistoryList { get; set; }
        public ICollection<BudgetCategory> BudgetCategories { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
