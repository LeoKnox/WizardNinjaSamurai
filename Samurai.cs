namespace ninja_wizard_samurai
{
    class Samurai : Human
    {
        public Samurai (string name) : base (name, 3, 3, 3, 200)
        {

        }

        public override void Attack(Human target)
        {
            target.health -= 5*Strength;
            if (target.health < 50) {
                target.health = 0;
            }
        }

        public void Meditate()
        {
            health = 200;    
        }
    }
}
