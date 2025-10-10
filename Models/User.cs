using System.ComponentModel.DataAnnotations;

namespace LearningScripts.Models
{
    public class User
    {
        [Required(ErrorMessage = "User name can't be null or empty")]
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public double? Price { get; set; }


        public override string ToString()
        {
            return $"User Object- User name:{UserName}, Email:{Email}," +
                $" Phone:{Phone}, Passwored:{Password}, Confirm password:{ConfirmPassword}";
        }
    }
}
