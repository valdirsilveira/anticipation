using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.EntityModel
{
    public static class AnticipationItemMap
    {
        public static void Map(this EntityTypeBuilder<AnticipationItem> entity)
        {
            entity.ToTable("antecipacaoitens");

            entity.HasKey(a => a.Id);

            entity.Property(a => a.Id).ValueGeneratedOnAdd();
            entity.Property(a => a.AnticipationId).HasColumnName("AntecipacaoId").IsRequired();

            entity.HasOne(a => a.Anticipation)
                        .WithMany(a => a.AnticipationItems)
                        .HasForeignKey(a => a.AnticipationId)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
