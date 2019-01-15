﻿using System;
using System.Collections.Generic;
using System.Text;

public class Seat : Car
{
    public Seat(string model, string color)
    {
        base.Model = model;
        base.Color = color;
    }

    public override string ToString()
    {
        return $"{Color} Seat {Model}\n" +
               $"{Start()}\n" +
               $"{Stop()}";
    }
}