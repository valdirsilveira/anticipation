using System.ComponentModel.DataAnnotations;

namespace api.Models.Validations
{
    public class JsonRequired : RequiredAttribute
    {
        public JsonRequired()
        {
            ErrorMessage = "{0}: Required.";
        }
    }
}
