Enemy Milim = new Enemy("Milim");
Attack Fireball = new Attack("fireball", 20);
Attack Punch = new Attack("punch", 10);
Attack Kick = new Attack("kick", 15);
Milim.AttackList.Add(Fireball);
Milim.AttackList.Add(Punch);
Milim.AttackList.Add(Kick);
Console.WriteLine("Using attack: " + Milim.RandomAttack().Name);