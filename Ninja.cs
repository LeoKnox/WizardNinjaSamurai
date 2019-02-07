using System;

namespace ninja_wizard_samurai
{
    class Ninja : Human
    {
        public Ninja(string name) : base (name, 3, 3, 175, 100)
        {

        }

        public override void Attack(Human target)
        {
            target.health -=5*Dexterity;
            Random rnd = new Random();
            int x=rnd.Next(1,6);
            if (x == 1)
            {
                target.health -= 10;
            }
        }

        public void Steal(Human target)
        {
            target.health -= 5;
            health += 5;
        }
    }
}
