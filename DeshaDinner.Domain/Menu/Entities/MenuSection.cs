using DeshaDinner.Domain.Common.Models;
using DeshaDinner.Domain.Menu.ValueObjects;

namespace DeshaDinner.Domain.Menu.Entities;

public sealed class MenuSection : Entity<MenuSectionId>
{
    public string Name { get; }
    public string Description { get; }
    private readonly List<MenuItem> _menuItems = new();

    public IReadOnlyList<MenuItem> items => _menuItems.AsReadOnly();
    private MenuSection(MenuSectionId id, string name, string description) : base(id)
    {
        Name = name;
        Description = description;
    }

    public static MenuSection Create(string name, string description)
    {
        return new(MenuSectionId.CreateUnique(), name, description);
    }
}
