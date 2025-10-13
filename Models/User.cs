using LearningScripts.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace LearningScripts.Models
{
    public class User : IValidatableObject
    {
        [Required(ErrorMessage = "{0} can't be null or empty")]
        [Display(Name = "User Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} and {1} long")]
        [RegularExpression("^[A-Za-z .]*$", ErrorMessage = "{0} should contain only alphabets, space and dot(.)")]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        //[ValidateNever]
        public string? Phone { get; set; }

        [Required]

        public string? Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "{0} and {1} do not match")]
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
        public double? Price { get; set; }

        [MinimumYearValidator(2005, ErrorMessage = "Date of Birth should be newer than Jan 01, {0}")]
        public DateTime? DateOfBirth { get; set; }

        public DateTime? FromDate { get; set; }

        [DateRangeValidator("FromDate", ErrorMessage = "'FromDate' should older than or equal to 'ToDate'")]
        public DateTime? ToDate { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            return $"User Object- User name:{UserName}, Email:{Email}," +
                $" Phone:{Phone}, Passwored:{Password}, Confirm password:{ConfirmPassword}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateOfBirth.HasValue == false && Age.HasValue == false)
            {
                yield return new ValidationResult("Either Date of birth or age must be supplied", new[] { nameof(Age) });
            }
        }
    }
}
