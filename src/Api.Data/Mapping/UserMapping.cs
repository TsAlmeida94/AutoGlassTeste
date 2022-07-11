using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u=> u.Id);
            builder.HasIndex(u => u.Codigo)
            .IsUnique();
            
            builder.Property(u => u.Codigo)
            .IsRequired();

            builder.Property(u => u.DescricaoDoProduto)
            .IsRequired();

            builder.Property(u => u.DataDeFabricacao)
            .IsRequired();
            
            builder.Property(u => u.DataDeValidade)
            .IsRequired();

            builder.Property(u => u.CodigoDoFornecedor)
            .IsRequired();

            builder.Property(u => u.DescricaoDoFornecedor)
            .IsRequired();

            builder.Property(u => u.CNPJDoFornecedor)
            .IsRequired();

            

        }
    }
}
