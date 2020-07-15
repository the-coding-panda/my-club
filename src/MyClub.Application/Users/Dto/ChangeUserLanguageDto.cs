using System.ComponentModel.DataAnnotations;

namespace MyClub.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}