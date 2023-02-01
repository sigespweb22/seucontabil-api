using System;

namespace BoxBack.Domain.Models
{
    public abstract class EntityAuditTenant : Entity
    {
        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public Guid TenantId { get; set;  }
    }
}