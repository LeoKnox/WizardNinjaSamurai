namespace ninja_wizard_samurai
{
    public class Human
{
	public string Name;
	public int Strength;
	public int Intelligence;
	public int Dexterity;
	public int health;
	
	public Human(string called)
	{
		Name = called;
		Strength = 3;
		Intelligence = 3;
		Dexterity = 3;
		health = 100;
	}
	
	public Human(string called, int str, int intel, int dex, int heal)
	{
		Name = called;
		Strength = str;
		Intelligence = intel;
		Dexterity = dex;
		health = heal;
	}
	
	public int damage
	{
		get { return health; }
	}
	
	public virtual void Attack(Human target)
	{
		target.health -= 5*Strength;
		System.Console.WriteLine($"Hit for {5*Strength} Damage!");
	}


	public override string ToString()
	{
		return $"{Name} str: {Strength} int: {Intelligence} dex: {Dexterity} hp: {health}";
	}
}
}
