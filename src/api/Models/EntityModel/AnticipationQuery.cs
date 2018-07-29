using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace api.Models.EntityModel
{
    public static class AnticipationQuery
    {
        #region OrderByDescendingCreatedAt
        public static IQueryable<Anticipation> OrderByDescendingCreatedAt(this IQueryable<Anticipation> anticipations)
        {
            return anticipations.OrderByDescending(anticipation => anticipation.CreatedAt);
        }
        #endregion

        #region IncludeAnticipationStatus
        public static IQueryable<Anticipation> IncludeAnticipationStatus(this IQueryable<Anticipation> anticipations)
        {
            return anticipations.Include(anticipation => anticipation.AnticipationStatusId);
        }
        #endregion

        #region WhereId
        public static IQueryable<Anticipation> WhereId(this IQueryable<Anticipation> anticipations, long anticipationId)
        {
            return anticipations.Where(anticipation => anticipation.Id == anticipationId);
        }
        #endregion[

        #region WhereNotStatusId
        public static IQueryable<Anticipation> WhereNotStatusId(this IQueryable<Anticipation> anticipations, long anticipationStatusId)
        {
            return anticipations.Where(anticipation => anticipation.AnticipationStatusId != anticipationStatusId);
        }
        #endregion
    }
}
