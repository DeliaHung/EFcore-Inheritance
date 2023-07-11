namespace EFcoreInheritance.Entity;

public class Cat : Pet
{
    public Cat(string name, int educationLevel)
        : base(name)
    {
        EducationLevel = educationLevel;
    }

    public int EducationLevel { get; set; }
    public override string Species => "Felis catus";

    public override string ToString()
        => $"Cat '{Name}' ({Species}/{Id}) with education '{EducationLevel}'";
}
