public class Hero
{
  public string Name;
  public int Level;
  public string HeroType;
  public Hero(string name, int level, string heroType)
  {
    this.Name = name;
    this.Level = level;
    this.HeroType = heroType;
  }
  public Hero()
  { }

  public string ToString()
  {
    return this.Name + " level " + this.Level + " " + this.HeroType;
  }
  public virtual string Attack()
  {
    return this.Name + " atacou com sua espada";
  }
}