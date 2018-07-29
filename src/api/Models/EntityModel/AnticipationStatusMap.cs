using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.EntityModel
{
    public static class AnticipationStatusMap
    {
        public static void Map(this EntityTypeBuilder<AnticipationStatus> entity)
        {
            entity.ToTable("antecipacaostatus");

            entity.HasKey(a => a.Id);

            entity.Property(a => a.Id).ValueGeneratedOnAdd();
            entity.Property(a => a.Description).HasColumnName("Descricao");
        }
    }
}
