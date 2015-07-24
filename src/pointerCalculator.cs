using System;

/// <summary>
/// @Author: Chris McCaslin
/// @Website: http://enragedcoding.rocks
/// @Date: 7/24/2015
/// </summary>

internal class PointerCalc
{
    /// <summary>
    /// main entrance point
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Console.Title = "Pointer Calculator";
        showMenu();
        Console.ReadLine();
    }

    /// <summary>
    /// showMenu function will ask the use which task they would like to perform.
    /// </summary>
    private static void showMenu()
    {
        Console.Clear();
        int num1 = 0, num2 = 0, total = 0;
        Console.WriteLine("Welcome to a pointer Calculator!");
        Console.WriteLine("Your only valid options are:(+, -, x, /, sqrt, exit) What would you like to do?");
        string op = Console.ReadLine();

        unsafe
        {
            try
            {
                switch (op)
                {
                    case "+":
                        Console.WriteLine("Please enter your first number");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your second number");
                        num2 = int.Parse(Console.ReadLine());

                        add(&total, &num1, &num2);

                        Console.WriteLine(num1 + " + " + num2 + " = " + total);
                        break;

                    case "-":
                        Console.WriteLine("Please enter your first number");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your second number");
                        num2 = int.Parse(Console.ReadLine());

                        subtract(&total, &num1, &num2);
                        Console.WriteLine(num1 + " - " + num2 + " = " + total);
                        break;

                    case "x":
                        Console.WriteLine("Please enter your first number");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your second number");
                        num2 = int.Parse(Console.ReadLine());

                        multiply(&total, &num1, &num2);
                        Console.WriteLine(num1 + " x " + num2 + " = " + total);
                        break;

                    case "/":
                        Console.WriteLine("Please enter your first number");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your second number");
                        num2 = int.Parse(Console.ReadLine());

                        divide(&total, &num1, &num2);
                        Console.WriteLine(num1 + " / " + num2 + " = " + total);
                        break;

                    case "sqrt":
                        Console.WriteLine("Please enter your first number");
                        num1 = int.Parse(Console.ReadLine());

                        sq(&total, &num1);
                        Console.WriteLine(num1 + " x " + num1 + " = " + total);
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        showMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    /// <summary>
    /// uses pointers to add
    /// </summary>
    /// <param name="total">the total to be set</param>
    /// <param name="num1">num1 to be added</param>
    /// <param name="num2">num2 to be added</param>
    private static unsafe void add(int* total, int* num1, int* num2)
    {
        *total = *num1 + *num2;
    }

    /// <summary>
    /// uses pointers to subtract
    /// </summary>
    /// <param name="total">the total to be set</param>
    /// <param name="num1">num1 to be subtracted</param>
    /// <param name="num2">num2 to  be subtracted</param>
    private static unsafe void subtract(int* total, int* num1, int* num2)
    {
        *total = *num1 - *num2;
    }

    /// <summary>
    /// uses pointers to multiply
    /// </summary>
    /// <param name="total">the total to be set</param>
    /// <param name="num1">num1 to be multiplied</param>
    /// <param name="num2">num2 to be multiplied</param>
    private static unsafe void multiply(int* total, int* num1, int* num2)
    {
        *total = *num1 * *num2;
    }

    /// <summary>
    /// uses pointer to divide
    /// </summary>
    /// <param name="total">the total to be set</param>
    /// <param name="num1">num1 to be divided</param>
    /// <param name="num2">num2 to be divided</param>
    private static unsafe void divide(int* total, int* num1, int* num2)
    {
        *total = *num1 / *num2;
    }

    /// <summary>
    /// uses pointers to sq-root num1
    /// </summary>
    /// <param name="total">the total to be set</param>
    /// <param name="num1">the num to sqrt</param>
    private static unsafe void sq(int* total, int* num1)
    {
        *total = *num1 * *num1;
    }
}