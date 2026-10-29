
namespace AnapaBooking.Domain.Common;

public abstract class BaseEntity 
{
    public Guid Id { get; protected set; } = Guid.NewGuid(); // Уникальный идентификатор 
    public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow; // Дата создания
    public DateTime? UpdatedAt { get; protected set; } // Дата обновления (может быть null)
    public void UpdateModifiedDate() //Метод обновления даты
    {
        UpdatedAt = DateTime.UtcNow;
    }


}
