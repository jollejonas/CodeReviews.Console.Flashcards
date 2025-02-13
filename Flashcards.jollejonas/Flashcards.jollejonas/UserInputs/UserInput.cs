﻿using Flashcards.jollejonas.Validation;

namespace Flashcards.jollejonas.UserInputs;

public class UserInput
{
    public static string GetStringInput(string message)
    {
        Console.WriteLine(message);
        string result = Console.ReadLine();
        if (InputValidation.ValidateString(result))
        {
            return result;
        }
        return null;
    }
}
