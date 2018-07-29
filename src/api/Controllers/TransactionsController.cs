using api.Infrastructure;
using api.Models.EntityModel;
using api.Models.ResultModel;
using api.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/v2/transactions")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private ApiDbContext _dbContext;

        public TransactionsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Consultar transações disponíveis para antecipar
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ProducesResponseType(200, Type = typeof(TransactionListJson))]
        [HttpGet, Route("available-anticipation")]
        public async Task<IActionResult> ListAvailableAnticipation([FromQuery] TransactionListModel model)
        {
            var transactionQuery = _dbContext.Transactions
                .WhereAvailableAnticipation();

            var transactions = await transactionQuery
                         .OrderByDescendingCreatedAt()
                         .ToListAsync();

            var periodTransactionAmount = await transactionQuery.SumAsync(transaction => transaction.TransactionAmount);
            var count = await transactionQuery.LongCountAsync();

            return new TransactionListJson(transactions, count, periodTransactionAmount);
        }
    }
}