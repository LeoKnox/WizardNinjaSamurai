namespace ninja_wizard_samurai
{
    class Wizard : Human
    {
        public Wizard(string name) : base (name, 3, 25, 3, 50)
        {

        }
    
        public override void Attack(Human target)
        {
            target.health -= 5*Intelligence;
            health += 5*Intelligence;
        }

        public void Heal(Human target)
        {
            target.health += 10*Intelligence;
        }
    }
}
