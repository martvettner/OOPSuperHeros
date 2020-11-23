using System;

namespace OOPSuperHeros
{
    class Program
    {
        class Player
        {
            string name;
            int hp;

            public Player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }
            public void SayHello()
            {
                Console.WriteLine($"{name} says Hello!");
            }
            public void ShowHp()
            {
                Console.WriteLine($"{name}'s HP: {hp} ");
            }
            public int MakeDam()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }
            public void TakeDam(int damage)
            {
                if(hp <= 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = hp - damage;
                }
            }
            public int HP
            {
                get { return hp; }
            }
            public string Name
            {
                get { return name; }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Name your first character: ");
            string charName1 = Console.ReadLine();
            Console.Write("Name your second character: ");
            string charName2 = Console.ReadLine();

            Player Player1 = new Player(charName1);
            Player Player2 = new Player(charName2);
            Player1.SayHello();
            Player1.ShowHp();
            Player2.SayHello();
            Player2.ShowHp();
           
            for(int i = 0; i < 3; i++)
            {
                Player1.TakeDam(Player2.MakeDam());
                Player2.TakeDam(Player1.MakeDam());
                Player1.ShowHp();
                Player2.ShowHp();
            }
            if (Player1.HP > Player2.HP)
            {
                Console.WriteLine($"{charName1} won!");
            }           
            else if(Player1.HP < Player2.HP)
            {
                Console.WriteLine($"{charName2} won!");
            }
            else
            {
                Console.WriteLine($"it's a tie");
            }
        }
    }
}
