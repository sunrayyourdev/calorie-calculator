namespace CalorieCalculator;

public class Validators
{


    public static float WeightInput()
    {
        return FloatInput(10, 300, 1, "weight");
    }
    

    public static float HeightInput()   
    {
        return FloatInput(0, 3, 2, "height");
    }


    public static int AgeInput()
    {
        return IntInput(1, 100, "age");
    }


    public static string GenderInput()
    {
        char gender_char = CharInput(['m', 'f'], "gender");
        if (gender_char == 'm')
        {
            return "Male";
        }
        else
        {
            return "Female";
        }
    }


    static float FloatInput(double min, double max, int decimal_places, string input_type)
    {
        float user_input;
        while (!float.TryParse(Console.ReadLine(), out user_input) || user_input < min || user_input > max)
        {
            Console.WriteLine($"Please enter a valid {input_type}");
        }
        return (float)Math.Round(user_input, decimal_places);
    }


    static int IntInput(double min, double max, string input_type)
    {
        int user_input;
        while (!int.TryParse(Console.ReadLine(), out user_input) || user_input < min || user_input > max)
        {
            Console.WriteLine($"Please enter a valid {input_type}");
        }
        return user_input;
    }


    static char CharInput(char[] expected_values, string input_type)
    {
        char user_input;
        while (!char.TryParse(Console.ReadLine(), out user_input) || !expected_values.Contains(char.ToLower(user_input)))
        {
            Console.WriteLine($"Please enter a valid {input_type}");
        }
        Console.WriteLine(user_input);
        return user_input;
    }
}
