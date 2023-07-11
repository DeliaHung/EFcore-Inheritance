namespace EFcoreInheritance.Entity;

public abstract class Animal
{
    protected Animal(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public abstract string Species { get; } //物種
}

public abstract class Pet : Animal
{
    protected Pet(string name)
        : base(name)
    {
    }
    public string? Vet { get; set; }

    public ICollection<Human> Humans { get; } = new List<Human>();
}
