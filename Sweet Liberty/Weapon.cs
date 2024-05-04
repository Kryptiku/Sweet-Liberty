using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Weapon : Item
{
    public int Damage { get; set; }
    public Weapon(string name, string description, int damage) : base(name, description)
    {
        Damage = damage;
    }
}