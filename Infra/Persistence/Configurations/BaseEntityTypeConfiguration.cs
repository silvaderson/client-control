using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configurations
{
    public abstract class BaseEntityTypeConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> builder)
        {
            builder.HasKey(b => b.Id).IsClustered();
            builder.Property<Guid>(b => b.Id)
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction)
                .IsRequired(true);

            builder.Property<DateTime>(b => b.CreatedAt)
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .IsRequired(true);

            builder.Property<DateTime?>(b => b.ModifiedAt)
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .IsRequired(false);
        }
    }
}
