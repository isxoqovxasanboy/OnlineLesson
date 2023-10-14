﻿// <auto-generated/>
using System;
using System.Threading;

/// <summary>
/// Bu yerdan dastur ishlashni boshlaydi 
/// </summary>
public class Program
{
    /// <summary>
    /// dastur ishga tushuvchi muxit
    /// </summary>
    private static void Main()
    {
        UICalculator();
    }

    /// <summary>
    /// UI kalkulyator vazifasi dasturni ishga tushirish va foydalanuvchiga qiymatni chiqarishdan iborat.
    /// </summary>
    static void UICalculator()
    {
        Console.WriteLine("--------------Calculator--------------");
        string result = SelectCorrectOrder
        (
            ReturnNumber("Enter first number: "),
            ReturnNumber("Enter second number: ")
        );
        Console.WriteLine($"It's resalt -> {result}");

    }

    /// <summary>
    /// Bu faqat son qaytaradi lekin matn kiritishni so'raydi negaki matnda nechanchi qiymatni kiritishingiz kerakligini aytib o'tasiz 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static decimal ReturnNumber(string text)
    {
        decimal number;
        string readForConsole;
        bool flag;
        do
        {
            Console.WriteLine(text);
            readForConsole = Console.ReadLine() ?? string.Empty;
            flag = decimal.TryParse(readForConsole, out number);
            if (flag)
            {
                if (!(number >= 1))
                {
                    Console.WriteLine("Please enter a number greater than zero");
                    flag = false;
                }
            }
            Thread.Sleep(500);
            Console.Clear();
        } while (string.IsNullOrEmpty(readForConsole) || !flag);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Success");
        Console.ResetColor();
        return number;
    }

    /// <summary>
    /// Bu ikkita qiymat kiritishingizni so'raydi va dastur davomida qiymatlarni berilgan buyruqqa qarab hisoblab beradi va 
    /// natijani matn ko'rinishida qaytaradi.
    /// </summary>
    /// <param name="numberOne"></param>
    /// <param name="numberTwo"></param>
    /// <returns></returns>
    static string SelectCorrectOrder(decimal numberOne, decimal numberTwo)
    {
        Console.Clear();
        string result;
        while (true)
        {
            try
            {
                Console.WriteLine("--------------Calculator--------------");
                Console.WriteLine("Enter correct orgument: *,/,+,-");
                result = Console.Read() switch
                {
                    '*' => $"{numberOne} * {numberTwo} = {numberOne * numberTwo}",
                    '/' => $"{numberOne} / {numberTwo} = {numberOne / numberTwo}",
                    '+' => $"{numberOne} + {numberTwo} = {numberOne + numberTwo}",
                    '-' => $"{numberOne} - {numberTwo} = {numberOne - numberTwo}",
                    _ => "false"
                };
                if (result != "false")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct orgument");
                    Console.ResetColor();
                    break;
                }

                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Enter correct result: *,/,+,-");
            }

        }

        return result;
    }
}

