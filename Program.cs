namespace SS_HW_1
{
    internal class CircleCalculations
    {
        public static void Main(string[] args)
        {
            /*int a;

            if (int.TryParse(Console.ReadLine(), out a))
            {
                int area = a * a;
                int perimeter = 4 * a;

                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);
            }
            else
            {
                Console.WriteLine("Please, enter an integer value");
            }*/
            /*string name;
            int age;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("How old are you, {0}?", name);
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Hello {0}, you are {1} years old :)", name, age);*/
            double r;
            double pi = 3.14;

            if (double.TryParse(Console.ReadLine(), out r))
            {
                double lengthValue = Math.Round(2 * pi * r, 2);
                double areaValue = Math.Round(pi * r * r, 2);
                double volumeValue = Math.Round(4.0 / 3.0 * pi * r * r * r, 2);

                Console.WriteLine($"length: {lengthValue}");
                Console.WriteLine($"area: {areaValue}");
                Console.WriteLine($"volume: {volumeValue}");
            }
            else
            {
                Console.WriteLine("Please, enter a double value");
            }
        }
    }
}
