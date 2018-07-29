using api.Infrastructure;
using api.Models.EntityModel;
using api.Models.ResultModel;
using api.Models.ServiceModel;
using api.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/v2/anticipations")]
    [ApiController]
    public class AnticipationsController : ControllerBase
    {
        private ApiDbContext _dbContext;

        public AnticipationsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Solicitar antecipação de transações selecionadas
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ProducesResponseType(200, Type = typeof(AnticipationJson))]
        [HttpPost, Route("request-anticipation")]
        public async Task<IActionResult> RequestAnticipation(RequestAnticipationModel model)
        {
            var anticipationProcessing = new AnticipationProcessing(_dbContext);

            if (!await anticipationProcessing.Process(model))
            {
                return BadRequest();
            }

            return new AnticipationJson(anticipationProcessing.Anticipation);
        }
    }
}