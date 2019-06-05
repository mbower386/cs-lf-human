namespace HumanClass
{
  class Human
  {
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;

    // add a public "getter" property to access health
    public int Health { get { return health; } }

    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human (string name)
    {
      this.Name = name;
      this.Strength = 3;
      this.Intelligence = 3;
      this.Dexterity = 3;
      this.health = 100;
    }

    // Add a constructor to assign custom values to all fields
    public Human (string name, int strength, int intel, int dex, int health)
    {
      this.Name = name;
      this.Strength = strength;
      this.Intelligence = intel;
      this.Dexterity = dex;
      this.health = health;
    }

    // Build Attack method
    public int Attack (Human target)
    {
      int dmg = 5 * this.Strength;
      target.health -= dmg;

      return target.health;
    }
  }
}