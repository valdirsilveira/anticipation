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

        public Anticipation Anticipation { get; set; }

        public async Task<bool> Process(RequestAnticipationModel model)
        {
            Anticipation = model.Map();

            _dbContext.Add(Anticipation);

            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
