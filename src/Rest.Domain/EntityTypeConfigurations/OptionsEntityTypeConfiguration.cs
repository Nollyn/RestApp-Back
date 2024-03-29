﻿using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public  class OptionsEntityTypeConfiguration : IEntityTypeConfiguration<Options>
    {
        public void Configure(EntityTypeBuilder<Options> builder)
        {
            builder.ToTable(nameof(Options));
            builder.HasKey(x => x.Id);
        }
    }
}
