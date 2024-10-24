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
            string name;
            int age;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("How old are you, {0}?", name);
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Hello {0}, you are {1} years old :)", name, age);
        }
    }
}
