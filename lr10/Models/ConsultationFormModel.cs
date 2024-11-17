using lr10.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class ConsultationFormModel
{
    [Required(ErrorMessage = "Будь ласка, введіть ім'я та прізвище.")]
    [Display(Name = "Ім'я та прізвище")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Будь ласка, введіть Email.")]
    [EmailAddress(ErrorMessage = "Неправильний формат Email.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Будь ласка, виберіть бажану дату консультації.")]
    [DataType(DataType.Date)]
    [FutureDate(ErrorMessage = "Дата консультації має бути в майбутньому.")]
    [WeekdayValidation(ErrorMessage = "Дата консультації не може бути на вихідних.")]
    [Display(Name = "Дата консультації")]
    public DateTime ConsultationDate { get; set; }

    [Required(ErrorMessage = "Будь ласка, оберіть продукт.")]
    [Display(Name = "Продукт")]
    public string Product { get; set; }
}
