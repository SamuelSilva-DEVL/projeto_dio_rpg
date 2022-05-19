public class Knight : Hero
{
  public Knight(string name, int level, string heroType)
  {
    this.Name = name;
    this.Level = level;
    this.HeroType = heroType;
  }

  public override string Attack()
  {
    return this.Name + " atacou com sua espada";
  }
}