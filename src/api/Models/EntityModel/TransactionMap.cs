using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.EntityModel
{
    public static class TransactionMap
    {
        public static void Map(this EntityTypeBuilder<Transaction> entity)
        {
            entity.ToTable("transacoes");

            entity.HasKey(t => t.Id);

            entity.Property(t => t.Id).ValueGeneratedOnAdd();
            entity.Property(t => t.AcquirerConfirmation).HasColumnName("ConfirmacaoAdquirente");
            entity.Property(a => a.CreatedAt).HasColumnName("DataTransacao").HasDefaultValueSql("getdate()").IsRequired();
            entity.Property(t => t.Installments).HasColumnName("parcelas").IsRequired();
            entity.Property(t => t.TransferDate).HasColumnName("DataRepasse");
            entity.Property(t => t.TransactionAmount).HasColumnName("ValorTransacao").HasColumnType("decimal(8,2)").IsRequired();
            entity.Property(t => t.TransferAmount).HasColumnName("ValorRepasse").HasColumnType("decimal(8,2)");
        }
    }
}
