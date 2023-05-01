using System.ComponentModel.DataAnnotations;

namespace FlexiCoudPay.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}