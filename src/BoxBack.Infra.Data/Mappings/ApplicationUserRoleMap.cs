using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BoxBack.Domain.Models;

namespace BoxBack.Infra.Data.Mappings
{
    public class ApplicationUserRoleMap : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            //Seeding the relation between our user and role to AspNetUserRoles table
            builder.HasData(
                //ROLE MASTER
                new ApplicationUserRole
                {
                    RoleId = "b0f96d85-3647-4651-9f78-b7529b577ec0",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );
        }
    }
}