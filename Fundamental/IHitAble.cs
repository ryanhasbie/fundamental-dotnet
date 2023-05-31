using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

/*
    Naming convension interface di C# diawali dengan huruf I sebelum nama interface 
*/

public interface IHitAble
{
    void GetHit(int demage);
    void Attack(IHitAble hitAble);

}
