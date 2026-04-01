using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

public class MovieC
{

    // return masked string
    public static bool ValidatePin(string pin)
    {
        bool isValid = true;
        if (pin.Length == 4 || pin.Length == 6)
        {
            bool hasLetters = pin.All(c => char.IsDigit(c));
            return isValid = hasLetters;
        }
        else
        {
            isValid = false;
        }
        return isValid;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(ValidatePin("1"));

    }
}