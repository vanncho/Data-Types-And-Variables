using System;

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature 
//of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely 
//to each other than a fixed constant eps.

    class ComparingFloats
{
    static void Main()
    {
        bool expl1 = false;
        bool expl2 = true;

        //Compares numbers 5.3 and 6.01
        double a1 = 5.3D;
        double b1 = 6.01D;
        double BA1 = b1-a1;

        Console.WriteLine("Number A: {0}", a1);
        Console.WriteLine("Number B: {0}", b1);

        if (BA1 >= 0.000001)
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl1);
        else
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl2);
        Console.WriteLine();

        //Compares numbers 5.00000001 and 5.00000003
        double a2 = 5.00000001D;
        double b2 = 5.00000003D;
        double BA2 = b2-a2;

        Console.WriteLine("Number A: {0}", a2);
        Console.WriteLine("Number B: {0}", b2);

        if (BA2 >= 0.000001)
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl1);
        else
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl2);
        Console.WriteLine();

        //Compares numbers 5.00000005 and 5.00000001
        double a3 = 5.00000005D;
        double b3 = 5.00000001D;
        double AB3 = a3 - b3;

        Console.WriteLine("Number A: {0}", a3);
        Console.WriteLine("Number B: {0}", b3);

        if (AB3 >= 0.000001)
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl1);
        else
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl2);
        Console.WriteLine();

        //Compares numbers -0.0000007 and 0.00000007
        double a4 = -0.0000007D;
        double b4 = 0.00000007D;
        double BA4 = b4 - a4;

        Console.WriteLine("Number A: {0}", a4);
        Console.WriteLine("Number B: {0}", b4);

        if (BA4 >= 0.000001)
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl1);
        else
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl2);
        Console.WriteLine();

        //Compares numbers -4.999999 and -4.999998
        double a5 = -4.999999D;
        double b5 = -4.999998D;
        double BA5 = b5 - a5;

        Console.WriteLine("Number A: {0}", a5);
        Console.WriteLine("Number B: {0}", b5);

        if (BA5 >= 0.000001)
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl1);
        else
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl2);
        Console.WriteLine();

        //Compares numbers 4.999999 and 4.999998
        double a6 = 4.999999D;
        double b6 = 4.999998D;
        double AB6 = a6 - b6;

        Console.WriteLine("Number A: {0}", a6);
        Console.WriteLine("Number B: {0}", b6);

        if (AB6 >= 0.000001)
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl1);
        else
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", expl2);
        Console.WriteLine();
    }
}
