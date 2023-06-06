// Attack fields:
//   name (i.e. fireball, punch, throw)
//   DamageAmount (i.e. a fireball will do 20 damage, keep the damage range between 5 and 25)
// Constructor: When an Attack is created, we must specify the Name and DamageAmount upon creation
public class Attack
{
  public string Name { get; set; }
  public int DamageAmount { get; set; }
  // Constructor
  public Attack(string name, int damageAmount)
  {
    Name = name;
    DamageAmount = damageAmount;
  }
}