﻿using System;
using System.Collections.Generic;
using System.Text;

public class Pet : IAnimal
{
    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    public string Name { get; private set; }
    public string Birthdate { get; private set; }

    public override string ToString()
    {
        return $"{this.Birthdate}";
    }
}
