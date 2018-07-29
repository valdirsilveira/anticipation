using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.EntityModel
{
    public static class AnticipationMap
    {
        public static void Map(this EntityTypeBuilder<Anticipation> entity)
        {
            entity.ToTable("Antecipacoes");

            entity.HasKey(a => a.Id);

            entity.Property(a => a.Id).ValueGeneratedOnAdd();
            entity.Property(a => a.AnalyzeDate).HasColumnName("DataAnalise");
            entity.Property(a => a.AnticipationStatusId).HasColumnName("AntecipacaoStatusId").IsRequired();
            entity.Property(a => a.AnalyzeResult).HasColumnName("ResultadoAnalise");
            entity.Property(a => a.CreatedAt).HasColumnName("DataAntecipacao").HasDefaultValueSql("getdate()").IsRequired();
            entity.Property(a => a.RequestedAmount).HasColumnName("ValorSolicitado").HasColumnType("decimal(8,2)").IsRequired();
            entity.Property(a => a.TransferAmount).HasColumnName("ValorRepasse").HasColumnType("decimal(8,2)");

            entity.HasOne(a => a.AnticipationStatus)
                .WithMany()
                .HasForeignKey(a => a.AnticipationStatusId);
        }
    }
}
