using api.Infrastructure;
using api.Models.EntityModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace api.Models.Validations
{
    public class ValidateAnticipation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var context = (ApiDbContext)validationContext
                         .GetService(typeof(ApiDbContext));

            var anticipation = context.Anticipations
                 .WhereId((long)value)
                 .SingleOrDefault();

            if (anticipation == null)
            {
                return new ValidationResult("Anticipation does not exist");
            }

            return ValidationResult.Success;
        }
    }
}
