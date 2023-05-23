using System.ComponentModel.DataAnnotations;

namespace University.Data.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Поле 'Ім'я' обов'язкове для заповнення.")]
        [StringLength(50, ErrorMessage = "Максимальна довжина поля 'Ім'я' - 50 символів.")]
        [MinLength(4, ErrorMessage = "Мінімальна довжина поля 'Ім'я' - 50 символів.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле 'Прізвище' обов'язкове для заповнення.")]
        [StringLength(50, ErrorMessage = "Максимальна довжина поля 'Прізвище' - 50 символів.")]
        [MinLength(4, ErrorMessage = "Мінімальна довжина поля 'Прізвище' - 50 символів.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Поле 'Адреса' обов'язкове для заповнення.")]
        [StringLength(100, ErrorMessage = "Максимальна довжина поля 'Адреса' - 100 символів.")]
        [MinLength(4, ErrorMessage = "Мінімальна довжина поля 'Адреса' - 100 символів.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Поле 'Номер телефона' обов'язкове для заповнення")]
        [MinLength(13, ErrorMessage = "Неправильний формат телефонного номера(+380...)")]
        [StringLength(13, ErrorMessage = "Неправильний формат телефонного номера(+380...)")]
        [RegularExpression(@"^\+380\d{9}$", ErrorMessage = "Неправильний формат телефонного номера(+380...)")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Поле 'Поштова адреса' обов'язкове для заповнення")]
        [EmailAddress(ErrorMessage = "Введіть правильний формат електронної пошти")]
        public string Email { get; set; }
    }
}
