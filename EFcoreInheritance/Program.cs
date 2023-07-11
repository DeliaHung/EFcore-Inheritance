using EFcoreConcurrency;
using EFcoreInheritance;

//Insert();
GetAll();
Console.WriteLine();

static void GetAll()
{
    using var dbcontext = new TestContext();
    Console.WriteLine("查詢父類(Hero)");
    var heros = dbcontext.Heroes.Where(hero => hero is EnergyHero || hero is ManaHero).ToList();
    heros.ForEach(hero =>
    {
        Console.WriteLine("---------------");
        Console.WriteLine("id : " + hero.Id);
        Console.WriteLine("Name : " + hero.Name);
        Console.WriteLine("HP : " + hero.HP);
        if (hero is EnergyHero)
        {
            var typeHero = (EnergyHero)hero;
            Console.WriteLine("Energy : " + typeHero.Energy);
        }
        if (hero is ManaHero)
        {
            var typeHero = (ManaHero)hero;
            Console.WriteLine("Mana : " + typeHero.Mana);
        }
        Console.WriteLine("---------------");
    });

    Console.WriteLine("查詢子類(EnergyHeroes)");
    var energyHeros = dbcontext.EnergyHeroes.ToList();

    energyHeros.ForEach(hero =>
    {
        Console.WriteLine("---------------");
        Console.WriteLine("id : " + hero.Id);
        Console.WriteLine("Name : " + hero.Name);
        Console.WriteLine("HP : " + hero.HP);
        Console.WriteLine("Energy : " + hero.Energy);
        Console.WriteLine("---------------");
    });

    Console.WriteLine("查詢子類(ManaHeroes)");
    var manaHeroes = dbcontext.ManaHeroes.ToList();
    manaHeroes.ForEach(hero =>
    {
        Console.WriteLine("---------------");
        Console.WriteLine("id : " + hero.Id);
        Console.WriteLine("Name : " + hero.Name);
        Console.WriteLine("HP : " + hero.HP);
        Console.WriteLine("Mana : " + hero.Mana);
        Console.WriteLine("---------------");
    });

    return;
}

static void Insert()
{
    using var dbcontext = new TestContext();
    EnergyHero energyHero = new() { Name = "能量英雄", HP = 100, Energy = 200 };
    ManaHero manaHero = new() { Name = "魔法英雄", HP = 100, Mana = 80 };
    dbcontext.Add(energyHero);
    dbcontext.Add(manaHero);
    dbcontext.SaveChanges();
}