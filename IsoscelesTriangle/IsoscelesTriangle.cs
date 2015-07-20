using System;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©

class IsoscelesTriangle
{
    static void Main()
    {
        char ch = '©';
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine(" " + " " + " " + ch + " " + " " + " ");
        Console.WriteLine(" " + " " + ch + " " + ch + " " + " ");
        Console.WriteLine(" " + ch + " " + " " + " " + ch + " ");
        Console.WriteLine(ch + " " + ch + " " + ch + " " + ch);
    }
}