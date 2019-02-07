using System;

namespace ninja_wizard_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard w = new Wizard("Steve");
            Samurai s = new Samurai("Sam");
            Ninja n = new Ninja("Nina");
            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine(w);
            w.Attack(s);
            s.Attack(n);
            n.Attack(w);
            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine(w);
            w.Heal(w);
            n.Steal(s);
            s.Meditate();
            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine(w);
        }
    }
}