using System.ComponentModel.DataAnnotations;

namespace Veterinary_Clinic.Presenters.Common
{
    public class ModelDataValidation
    {
        public static void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> results = [];
            ValidationContext context = new (model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (isValid == false)
            {
                foreach (var item in results)
                    errorMessage += "- " + item.ErrorMessage + "\n";
                throw new Exception(errorMessage);
            }
        }
    }
}
