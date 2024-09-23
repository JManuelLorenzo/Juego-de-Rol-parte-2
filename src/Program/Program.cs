/*using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook();
book.Spells = new Spell[]{ new Spell() };

Wizard gandalf = new Wizard("Gandalf");
gandalf.Staff = new Staff();
gandalf.SpellsBook = book;

Dwarf gimli = new Dwarf("Gimli");
gimli.Axe = new Axe();
gimli.Helmet = new Helmet();
gimli.Shield = new Shield();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf.AttackValue);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

*/ 

// ####Prueba de Knights:####

using Ucu.Poo.RoleplayGame;
Knight Jane = new Knight("Jane");
Knight Augustos = new Knight("Augustos");

Jane.Sword = new Sword(90);
Jane.Shield = new Shield(3);
Jane.Armor = new Armor(4);
Augustos.Sword = new Sword(5);
Augustos.Shield = new Shield(6);
Augustos.Armor = new Armor(6);

Console.WriteLine(Augustos.Health);
Augustos.ReceiveAttack(Jane.AttackValue);
Console.WriteLine(Augustos.Health);
Augustos.Cure();
