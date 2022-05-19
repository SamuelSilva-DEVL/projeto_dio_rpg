using static System.Console;
public class Program
{
  public static void Main()
  {
    Hero arus = new Hero("Arus", 15, "Knigt");
    Wizard wizard = new Wizard("Wizard", 2, "Wizard");

    WriteLine(arus.ToString());
    WriteLine(wizard.ToString());

    WriteLine(wizard.Attack(2));
  }
}
