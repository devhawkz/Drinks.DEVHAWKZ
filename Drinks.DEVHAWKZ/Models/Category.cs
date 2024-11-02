using System.ComponentModel.DataAnnotations;

namespace Drinks.DEVHAWKZ.Models;

public class Category
{
    public string Name { get; set; } = string.Empty;


    public override bool Equals(object? obj)
    {
        return obj is Category category && Name == category.Name;
    }

    public override int GetHashCode() => HashCode.Combine(Name);
}
