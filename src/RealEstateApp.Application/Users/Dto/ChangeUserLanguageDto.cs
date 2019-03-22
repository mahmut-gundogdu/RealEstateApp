using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}