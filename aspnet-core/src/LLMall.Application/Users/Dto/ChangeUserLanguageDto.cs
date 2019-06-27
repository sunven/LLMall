using System.ComponentModel.DataAnnotations;

namespace LLMall.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}