using api.Infrastructure;
using api.Models.EntityModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace api.Models.Validations
{
    public class ValidateTransaction : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var context = (ApiDbContext)validationContext
                         .GetService(typeof(ApiDbContext));

            var anticipation = context.Transactions
                 .WhereId((long)value)
                 .SingleOrDefault();

            if (anticipation == null)
            {
                return new ValidationResult("Transaction does not exist");
            }

            return ValidationResult.Success;
        }
    }
}
