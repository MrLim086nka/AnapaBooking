
namespace AnapaBooking.Domain.Entities;

using AnapaBooking.Domain.Common;
using AnapaBooking.Domain.Enums;

public class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty; // Имя 
    public string LastName { get; set; } = string.Empty; // Фамилия
    public string Email { get; set; } = string.Empty; // Электронная почта
    public string PasswordHash { get; set; } = string.Empty; // Хэш пароля
    public string PhoneNumber { get; set; } = string.Empty; // Номер телефона
    public UserRole Role { get; set; } = UserRole.Guest; // Роль пользователя
}
