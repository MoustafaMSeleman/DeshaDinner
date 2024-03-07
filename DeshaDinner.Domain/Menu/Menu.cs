using DeshaDinner.Domain.Common.Models;
using DeshaDinner.Domain.Dinner.ValueObjects;
using DeshaDinner.Domain.Host.ValueObjects;
using DeshaDinner.Domain.Menu.Entities;
using DeshaDinner.Domain.Menu.ValueObjects;
using DeshaDinner.Domain.MenuReview.ValueObjects;

namespace DeshaDinner.Domain.Menu;

public sealed class Menu : AggregateRoot<MenuId>
{
    public string Name { get; }
    public string Description { get; }
    public decimal? AverageRating { get; }

    private readonly List<MenuSection> _menuSections = new ();

    public IReadOnlyList<MenuSection> menuSections => _menuSections.AsReadOnly ();

    public HostId HostId { get; }

    private readonly List<DinnerId> _dinnerIds = new();
    public IReadOnlyList<DinnerId> DinnerIds => _dinnerIds.AsReadOnly ();

    private readonly List<MenuReviewId> _menuReviewIds = new();
    public IReadOnlyList<MenuReviewId> menuReviewIds => _menuReviewIds.AsReadOnly ();

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Menu(MenuId id,
                 string name,
                 string description,
                 HostId hostId,
                 DateTime createdDateTime,
                 DateTime updatedDateTime
                 ) : base(id)
    {
        Name = name;
        Description = description;
        HostId = hostId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Menu Create(string name,
                 string description,
                 HostId hostId)
    {
        return new Menu(MenuId.CreateUnique(), name, description, hostId, DateTime.UtcNow, DateTime.UtcNow);
    }
}
