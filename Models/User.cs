using System.ComponentModel.DataAnnotations;

namespace LearningScripts.Models
{
    public class User
    {
        [Required(ErrorMessage = "{0} can't be null or empty")]
        [Display(Name = "User Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} and {1} long")]
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
        public double? Price { get; set; }


        public override string ToString()
        {
            return $"User Object- User name:{UserName}, Email:{Email}," +
                $" Phone:{Phone}, Passwored:{Password}, Confirm password:{ConfirmPassword}";
        }
    }
}
