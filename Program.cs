
namespace BoxerWeightClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the boxer's weight in pounds: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            string classification = GetWeightClassification(weight);

            Console.WriteLine($"The boxer's weight classification is: {classification}");
        }

        static string GetWeightClassification(double weight)
        {
            if (weight > 190) return "Heavyweight";
            else if (weight > 175) return "Cruiserweight";
            else if (weight > 168) return "Light Heavyweight";
            else if (weight > 160) return "Super Middleweight";
            else if (weight > 154) return "Middleweight";
            else if (weight > 147) return "Junior Middleweight";
            else if (weight > 140) return "Welterweight";
            else return "Junior Welterweight";
        }
    }
}