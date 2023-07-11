namespace EFcoreInheritance.Entity;

public class Dog : Pet
{
    public Dog(string name, string favoriteToy)
        : base(name)
    {
        FavoriteToy = favoriteToy;
    }

    public string FavoriteToy { get; set; }
    public override string Species => "Canis familiaris";

    public override string ToString()
        => $"Dog '{Name}' ({Species}/{Id}) with favorite toy '{FavoriteToy}'";
}
