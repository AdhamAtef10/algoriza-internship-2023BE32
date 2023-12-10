using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Repository.Data.Config
{
    internal class TimeConfigurations : IEntityTypeConfiguration<Times>
    {
        public void Configure(EntityTypeBuilder<Times> builder)
        {
            builder.Property(T => T.Time).HasColumnType("datetime");
        }
    }
}
