using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

public class Hero : IHitAble
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int BaseDemage { get; set; }

    public void Attack (IHitAble hitAble)
    {
        //Console.WriteLine($"{Name} attacked {hero.Name} ");
        hitAble.GetHit(BaseDemage);
    }

    /* public void Attack(Monster monster)
    {
        Console.WriteLine($"{Name} attacked {monster.Name}");
        monster.GetHit(BaseDemage);
    } */

    public void GetHit (int damage)
    {
        Console.WriteLine($"{Name} get hit: {damage}");
        Hp -= damage;
    }
}

/* public class Program
{
    public static void Main(string[] args)
    {
        IHitAble layla = new Hero
        {
            Name= "Layla",
            Hp = 1000,
            BaseDemage = 200
        };

        IHitAble hayabusa = new Hero
        {
            Name = "Hayabusa",
            Hp = 1000,
            BaseDemage = 250
        };

        IHitAble minion = new Monster
        {
            Name = "Minion",
            Hp = 600,
            BaseDemage = 100
        };

        // layla.Attack(hayabusa);
        // Console.WriteLine($"{hayabusa.Name} hp is: {hayabusa.Hp}");

        layla.Attack(minion);
        minion.Attack(layla);
    }
} */
