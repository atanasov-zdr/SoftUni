﻿using System;
using System.Collections.Generic;
using System.Text;

public class Tuple<T1, T2>
{
    public Tuple(T1 item1, T2 item2)
    {
        this.Item1 = item1;
        this.Item2 = item2;
    }

    public T1 Item1 { get; }

    public T2 Item2 { get; }

    public override string ToString()
    {
        var result = $"{this.Item1} -> {this.Item2}";
        return result;
    }
}