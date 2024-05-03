using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Location
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public string LocationToNorth { get; set; }
    public string LocationToEast { get; set; }
    public string LocationToSouth { get; set; }
    public string LocationToWest { get; set; }
    public Dictionary<string, Item> Items { get; set; } = new Dictionary<string, Item>();
    public Item ItemRequired { get; set; }

    public Location(string name,
            string displayName,
            string description,
            string locationToNorth = "",
            string locationToEast = "",
            string locationToSouth = "",
            string locationToWest = "",
            List<Item> listItem = null,
            Item itemRequired = null)
    {
        Name = name;
        DisplayName = displayName;
        Description = description;
        LocationToNorth = locationToNorth;
        LocationToEast = locationToEast;
        LocationToSouth = locationToSouth;
        LocationToWest = locationToWest;
        if (listItem != null)
            CreateDictionary(listItem);
        ItemRequired = itemRequired;
    }

    private void CreateDictionary(List<Item> itemList)
    {
        foreach (Item item in itemList)
        {
            Items.Add(item.Name, item);
        }
    }

    public void AddItem(Item item)
    {
        Items.Add(item.Name, item);
    }
    public void RemoveItem(Item item)
    {
        Items.Remove(item.Name);
    }
    public void RemoveItem(string itemName)
    {
        Items.Remove(itemName);
    }

}

