
namespace AnapaBooking.Domain.Entities;

using AnapaBooking.Domain.Common;
using AnapaBooking.Domain.Enums;

public class Booking: BaseEntity
{
    public Guid ApartmentId { get; set; } // Идентификатор бронируемой квартиры
    public Guid GuestId { get; set; } // Идентификатор гостя(User) который бронирует 
    public DateTime CheckInDate { get; set; } // Дата заезда
    public DateTime CheckOutDate { get; set; } // Дата выезда
    public decimal TotalPrice { get; set; } // Общая стоимость бронирования
    public BookingStatus Status { get; set; } = BookingStatus.Pending; // Статус бронирования
}
