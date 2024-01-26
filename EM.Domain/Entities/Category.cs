using EM.Domain.Common;

namespace EM.Domain.Entities
{
    public class Category : BaseAuditableEntity
    {
        public bool IsDelete { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public bool IsDefault { get; set; }
        public int Order { get; set; }
        public User CreateUser { get; set; }
        public User? ModifiedUser { get; set; }
    }
}
