// Created by: Aiden McLeod
// Created on: Sep 2022
//
// This program finds area of a kite

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Diagonal A:");
        double Diagonala = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Diagonal B:");
        double Diagonalb = Convert.ToDouble(Console.ReadLine());

        double Area = (Diagonala * Diagonalb) / 2;
        Console.Write("Area of a Kite = " + Area + "cm²");
        Console.ReadKey();
    }
}
