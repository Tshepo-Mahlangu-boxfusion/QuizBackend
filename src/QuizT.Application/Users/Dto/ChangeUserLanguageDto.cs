using System.ComponentModel.DataAnnotations;

namespace QuizT.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}