﻿using Lab3.Examples.Bank;
using Lab3.Examples.Hospital;

namespace Lab3;

internal class Program
{
    public static void Main(string[] args)
    {
        var model = HospitalHelper.CreateModel();
        model.Simulate(1000);
    }
}
