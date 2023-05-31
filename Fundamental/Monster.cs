using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

public class Monster: IHitAble
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int BaseDemage { get; set; }

    public void GetHit(int damage)
    {
        Console.WriteLine($"{Name} get hit: {damage}");
        Hp -= damage;
    }

    public void Attack(IHitAble hitAble) 
    { 
        hitAble.GetHit(BaseDemage);
    }
}
