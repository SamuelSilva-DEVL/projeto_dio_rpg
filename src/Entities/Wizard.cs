public class Wizard : Hero
{
  public Wizard(string name, int level, string heroType)
  {
    this.Name = name;
    this.Level = level;
    this.HeroType = heroType;
  }
  public Wizard()
  { }
  public override string Attack()
  {
    return this.Name + " atacou com sua magia";
  }

  public string Attack(int bonus)
  {
    return this.Name + " atacou com sua magia com bonus de + " + bonus;
  }
}