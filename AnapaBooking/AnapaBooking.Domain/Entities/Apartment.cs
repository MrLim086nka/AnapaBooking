using AnapaBooking.Domain.Common;

namespace AnapaBooking.Domain.Entities;

public class Apartment: BaseEntity
{
    public string Title { get; set; } = string.Empty; // Название
    public string Description { get; set; } =  string.Empty; // Описание
    public string Address { get; set; } = string.Empty; // Адрес
    public decimal PricePerNight { get; set; } // Стоимость за ночь
    public Guid HostId { get; set; } // Идентификатор владельца



}
