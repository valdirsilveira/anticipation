using api.Models.EntityModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace api.Infrastructure
{
    public static class ApiDbSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApiDbContext>();
            context.Database.EnsureCreated();

            #region AnticipationStatus
            if (!context.AnticipationStatus.Any())
            {
                context.AnticipationStatus.Add(new AnticipationStatus() { Description = "Aguardando análise" });
                context.AnticipationStatus.Add(new AnticipationStatus() { Description = "Em análise" });
                context.AnticipationStatus.Add(new AnticipationStatus() { Description = "Finalizada" });
                context.SaveChanges();
            }
            #endregion

            #region Transactions
            if (!context.Transactions.Any())
            {
                context.Transactions.Add(new Transaction()
                {
                    AcquirerConfirmation = true,
                    CreatedAt = DateTime.Now,
                    Installments = 1,
                    TransactionAmount = (decimal)250.00
                });
                context.Transactions.Add(new Transaction()
                {
                    AcquirerConfirmation = true,
                    CreatedAt = DateTime.Now,
                    Installments = 1,
                    TransactionAmount = (decimal)300
                });
                context.Transactions.Add(new Transaction()
                {
                    AcquirerConfirmation = true,
                    CreatedAt = DateTime.Now,
                    Installments = 2,
                    TransactionAmount = (decimal)500
                });
                context.SaveChanges();
            }         
            #endregion
        }
    }
}
