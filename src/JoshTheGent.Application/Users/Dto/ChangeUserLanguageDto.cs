using System.ComponentModel.DataAnnotations;

namespace JoshTheGent.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}