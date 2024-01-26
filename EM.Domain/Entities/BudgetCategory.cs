namespace EM.Domain.Entities
{
    public class BudgetCategory
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public double ProjectedCost { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }
}
