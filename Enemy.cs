// Enemy fields:
//   Name (i.e. Bandit, Boss, Guard)
//   Health
//   AttackList -- This will be a List of type Attack that will hold the various Attacks an enemy can perform
// Constructor: 
//   When an Enemy is created, we must provide their Name upon creation
//   Health will start at a default value of 100
//   AttackList will initialize as an empty List
// Methods:
//   RandomAttack: the enemy object performs a randomized attack from their AttackList (hint: remember Random()?)

public class Enemy
{
  public string Name { get; set; }
  public List<Attack> AttackList { get; set; }
  private int Health { get; set; }
  public int _Health
  {
    get
    {
      return Health;
    }
  }

  // Constructor
  public Enemy(string name, int health = 100)
  {
    Name = name;
    Health = health;
    AttackList = new List<Attack>();
  }

  public void AddAttack(Attack attack)
  {
    AttackList.Add(attack);
  }
  public Attack RandomAttack()
  {
    Random rand = new Random();
    int idx = rand.Next(AttackList.Count);
    return AttackList[idx];
  }
}