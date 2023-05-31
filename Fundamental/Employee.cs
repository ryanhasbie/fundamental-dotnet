using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental;

public class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Division { get; set; }

    public virtual void SayHello(Employee employee)
    {
        Console.WriteLine($"Hi, {employee.Name}");
    }
}

public class Manager : Employee
{
    public override void SayHello (Employee employee)
    {
       Console.WriteLine($"Hi, {employee.Name}. This is Manager {Name}");
       // base.SayHello(employee);
    }
}

public class Supervisor : Manager
{
    public override void SayHello(Employee employee)
    {
        Console.WriteLine($"Hi, {employee.Name}. This is Supervisor {Name}");
        // base.SayHello(employee);
    }

    public void SayHi() 
    {
        Console.WriteLine("Say Hi from Supervisor");
    }
}

/* public class Program
{
    public static void Main(string[] args)
    {
       /* var manager = new Manager
        {
            Name = "Ryan",
        };

        var budi = new Employee
        {
            Name = "Budi",
            Division = "Developer"
        };

        manager.SayHello(budi); 

        Supervisor andi = new Supervisor();
        andi.Name = "Andi 1";
        andi.SayHi();
        // Harus mulai dari parentnya dulu
        Employee andi2 = new Supervisor();
        andi2.Name = "Andi 2";
        andi.SayHi();
    }
} */
