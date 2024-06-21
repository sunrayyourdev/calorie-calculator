namespace CalorieCalculator;

public class Calculator(float weight, float height, int age, string gender)
{
    public float Weight { get; set; } = weight;
    public float Height { get; set; } = height;
    public int Age { get; set; } = age;
    public string Gender { get; set; } = gender;
    public double BMI {
        get { return Math.Round(Weight /(Height*Height), 2); }
    }
    public int BMR {
        get { 
            if (Gender == "Male")
            {
                return (int)(88.362 + (13.397 * Weight) + (4.799 * Height * 100) - (5.677 * Age));
            }
            else
            {
                return (int)(447.593 + (9.247 * Weight) + (3.098 * Height) - (4.330 * Age));
            }
        }
    }

    public string DisplayAllInfo()
    {
        return $"Weight: {Weight}kg\nHeight: {Height}m\nAge: {Age}\nGender: {Gender}\nBMI: {BMI}\nBMR: {BMR}";
    }

    public string BMIAnalysis()
    {
        double bmi = BMI;
        string healthy_weight_range = $"{Math.Round(Height*Height*18.6, 2)} - {Math.Round(Height*Height*24.9, 2)}";
        if (bmi >= 40)
        {
            return $"You are a fucking fat cunt\nHealthy weight: {healthy_weight_range}";
        }
        if (bmi >= 30)
        {
            return $"You are obese\nHealthy weight: {healthy_weight_range}";
        }
        if (bmi >= 25)
        {
            return $"You are overweight\nHealthy weight: {healthy_weight_range}";
        }
        if (bmi >= 18.5)
        {
            return $"You are normal";
        }
        return $"You are underweight\nHealthy weight: {healthy_weight_range}";
    }
}