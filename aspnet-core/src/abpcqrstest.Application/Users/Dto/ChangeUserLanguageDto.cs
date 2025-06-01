using System.ComponentModel.DataAnnotations;

namespace abpcqrstest.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}