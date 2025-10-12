using System.ComponentModel.DataAnnotations;

namespace LearningScripts.CustomValidators
{
    public class MinimumYearValidatorAttribute : ValidationAttribute
    {
        public int MinimuYear { get; set; } = 2000;

        public string DefaultErrorMessage { get; set; } = "Year should be greater than {0}";
        public MinimumYearValidatorAttribute() { }

        public MinimumYearValidatorAttribute(int minimuYear)
        {
            MinimuYear = minimuYear;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                if (date.Year <= MinimuYear)
                {
                    return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMessage, MinimuYear));
                }
                else
                {
                    return ValidationResult.Success;
                }
            }

            return null;
        }
    }
}
