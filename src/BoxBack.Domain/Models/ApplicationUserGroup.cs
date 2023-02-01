using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxBack.Domain.Models
{
    public class ApplicationUserGroup
    {        
        // Constructor empty for EF
        public ApplicationUserGroup() {}

        // Relationships
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
        [ForeignKey("GroupId")]
        public Guid GroupId { get; set; }
        public ApplicationGroup ApplicationGroup { get; set; }
    }
}