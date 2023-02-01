using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxBack.Domain.Models
{
    public class ApplicationRoleGroup
    {        
        // Constructor empty for EF
        public ApplicationRoleGroup() {}

        // Relationships
        [ForeignKey("RoleId")]
        public string RoleId { get; set; }
        public ApplicationRole ApplicationRole { get; set; }

        [ForeignKey("GroupId")]
        public Guid GroupId { get; set; }
        public ApplicationGroup ApplicationGroup { get; set; }
    }
}