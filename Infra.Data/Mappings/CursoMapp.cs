using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mappings
{
    internal class CursoMapp : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Curso");

            builder.HasKey(x => x.Id);

            builder.Property(c => c.Nomenclatura).HasColumnName("Nomenclatura").HasColumnType("varchar(50)");
            builder.Property(c => c.CargaHoraria).HasColumnName("CargaHoraria").HasColumnType("int");
            builder.Property(c => c.Dependencia).HasColumnName("Dependencia").HasColumnType("smallint");
            builder.Property(c => c.PreRequisito).HasColumnName("PreRequisito").HasColumnType("varchar(50)");

        }
    }
}
