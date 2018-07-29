using api.Infrastructure;
using api.Models.EntityModel;
using api.Models.ViewModel;
using System.Threading.Tasks;

namespace api.Models.ServiceModel
{
    public class AnticipationProcessing
    {
        private ApiDbContext _dbContext;

        public AnticipationProcessing(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Anticipation Anticipation { get; private set; }

        public async Task<bool> Process(RequestAnticipationModel model)
        {
            Anticipation = model.Map();

            foreach (var item in model.Transactions)
            {
                Anticipation.AnticipationItems.Add(new AnticipationItem {
                     AnticipationId = Anticipation.Id,
                     TransactionId = item.Id
                });
            }

            _dbContext.Add(Anticipation);

            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
