using System.ComponentModel.DataAnnotations;

namespace DemoVineForce.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}