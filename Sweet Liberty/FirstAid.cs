﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    internal class FirstAid : Item
    {
        public int Value { get; set; }
        public FirstAid(string name, string description, int value) : base(name, description)
        {
            Value = value;
            // for debugging
            // DisplayInfo();
        }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Item: {Name}, Description: {Description}, Healing Value: {Value}");
    }
}
