using System;

public class Character
{
    public string name;
    public int pv;
    public int strength;
    public int defense;
    public bool alive;
    public bool IsAlive(bool alive)
    {
        return alive;
    }

    public void Attack(Character enemy, Character attacker)
    {
        enemy.pv = (enemy.pv) - (attacker.strength - enemy.defense);
    }
}
namespace a
{
    public class Program
    {

        public static void Main()
        {
            Character firstPlayer = new Character();
            firstPlayer.name = "First";
            firstPlayer.pv = 100;
            firstPlayer.strength = 10;
            firstPlayer.strength = 10;
            firstPlayer.alive = true;

            Character secondPlayer = new Character();
            secondPlayer.name = "Second";
            secondPlayer.pv = 100;
            secondPlayer.strength = 5;
            secondPlayer.strength = 5;
            secondPlayer.alive = true;
          
            while (firstPlayer.IsAlive(true) || secondPlayer.IsAlive(true))
            {
                if (firstPlayer.pv < 0)
                {
                    firstPlayer.alive = false;
                    Console.WriteLine($"{secondPlayer.name} has won.");
                    break;
                } else if (secondPlayer.pv <= 0)
                {
                    secondPlayer.alive = false;
                    Console.WriteLine($"{firstPlayer.name} has won.");
                    break;
                } else
                {
                    firstPlayer.Attack(secondPlayer, firstPlayer);
                    secondPlayer.Attack(firstPlayer, secondPlayer);
                }
            }
        }
    }
}
