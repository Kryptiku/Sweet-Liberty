﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Log : Item
{
    public string Message { get; set; }
    public Log(string name, string description, string message) : base(name, description)
    {
        Message = message;
    }
}
