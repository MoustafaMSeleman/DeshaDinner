using DeshaDinner.Application.Common.Interfaces;

namespace DeshaDinner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
