namespace CalorieCalculator;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter weight (kg): ");
        float weight = Validators.WeightInput();
        
        Console.WriteLine("Enter height (m): ");
        float height = Validators.HeightInput();
        
        Console.WriteLine("Enter age: ");
        int age = Validators.AgeInput();

        Console.WriteLine("Enter gender (m/f): ");
        string gender = Validators.GenderInput();

        Calculator calculator = new(weight, height, age, gender);
        Console.WriteLine(calculator.DisplayAllInfo());
        Console.WriteLine(calculator.BMIAnalysis());
    }
}
