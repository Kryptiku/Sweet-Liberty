using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Item(string name, string description)
    {
        Name = name;
        Description = description;
        // for debugging
        // DisplayInfo();
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Item: {Name}, Description: {Description}");
    }
}
