﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfigurations : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //many to many
            builder.HasMany(f => f.Passengers)
                   .WithMany(p => p.Flights)
                   .UsingEntity(e => e.ToTable("Reservations"));//table d'association
            //one to many
            builder.HasOne(f=>f.Plane)
                   .WithMany(p=>p.Flights)
                   //.HasForeignKey(k=>k.PlaneFK)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
