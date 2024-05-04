﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Player
{
    public static string Name { get; set; }
    public static string Character;
    public static int Strength;
    public static int Health { get; set; }
    public static Dictionary<string, Item> Inventory = new Dictionary<string, Item>();
    public static Item ItemInHand;

    public static void AddToInventory(Item item)
    {
        Inventory.Add(item.Name, item);
    }

    public static void GetItemFromInventory(Item item)
    {
        ReturnItemToInventory();
        ItemInHand = item;
        Inventory.Remove(item.Name);
    }

    public static void GetItemFromInventory(string itemName)
    {
        GetItemFromInventory(Inventory[itemName]);
    }

    public static void ReturnItemToInventory()
    {
        if (ItemInHand != null)
        {
            Inventory.Add(ItemInHand.Name, ItemInHand);
        }
        ItemInHand = null;
    }

}