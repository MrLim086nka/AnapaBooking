
namespace AnapaBooking.Domain.Enums;

public enum BookingStatus
{
    Pending=1, // Ожидает подтверждение
    Confirmed=2, // Подтверждено
    Canceled=3, // Отменено
    Completed=4 // Завершено 
}
