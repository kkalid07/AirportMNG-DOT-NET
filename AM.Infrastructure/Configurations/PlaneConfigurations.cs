using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PlaneConfigurations : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(p=>p.PlaneId);
            builder.ToTable("MyPlanes");
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");

            //many to one
            /*builder.HasMany(p=>p.Flights)
                   .WithOne(f=>f.Plane)
                   .HasForeignKey(k=>k.PlaneFK)
                   .OnDelete(DeleteBehavior.Cascade);*/
        }
    }
}
