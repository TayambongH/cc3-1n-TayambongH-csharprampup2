namespace csharpact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1:");
            Console.WriteLine("Enter weight in Pounds (lbs): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double kilograms = weight * 0.45359237;


            // Convertion of Distance
            Console.WriteLine("Enter length in Miles (mi): ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.609344;


            // Convertion of Temparature
            Console.WriteLine("Enter temperature in Fahrenheit (°F): ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;


            // Average Age Calculation
            double sum = 0;
            int[] userInput = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter age of student {i + 1}: ");
                userInput[i] = Convert.ToInt32(Console.ReadLine());
                sum += userInput[i];
            }
            double average = sum / 10;


            // Fantasy Story
            string character1 = "Natsu";
            string character2 = "Lucy";
            string character3 = "Happy";
            string character4 = "Erza";
            string character5 = "Grey";
            string item1 = "Dragon Force";
            string item2 = "Celestial key";
            string ability1 = "immortal";
            string ability2 = "Dark Arts";


            //Output Part 1
            Console.WriteLine("====================================");
            Console.WriteLine("Weight in Pounds (lbs): " + weight);
            Console.WriteLine("Weight in Kilograms (kg): " + kilograms);
            Console.WriteLine("====================================");
            Console.WriteLine("Length in Miles (mi): " + miles);
            Console.WriteLine("Length in Kilometers (km): " + kilometers);
            Console.WriteLine("====================================");
            Console.WriteLine("Temperature in Fahrenheit (°F): " + fahrenheit);
            Console.WriteLine("Temperature in Celsius (°C): " + celsius);
            Console.WriteLine("====================================");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Age of student {i + 1}: {userInput[i]}");
            }
            Console.WriteLine("The average age of the students is: " + average);
            Console.WriteLine("====================================");
            Console.WriteLine("Fantasy Story: ");
            Console.WriteLine($"Once upon a time, in the kingdom of Fiorre, {character1}, {character2}, {character3}, {character4}, and {character5} went on a hundred year quest to find the legendary dragon, Igneel.");
            Console.WriteLine($"It is rumored that whoever finds him will be granted the two legendary items, {item1}, and the {item2}.");
            Console.WriteLine($"During their journey, they encountered Zeref, who is {ability1}. With his {ability2}, he can kill anyone he desires.");
            Console.WriteLine($"Defeating him is near impossible, but with the legendary items, {item1}, and {item2}, they might have a chance.");
            Console.WriteLine($"Together, they overcame various obstacles and found Igneel. They finally acquired the {item1} and {item2}. With these items they were able to defeat Zeref.");
            Console.WriteLine("====================================");

            //Part 2
            Console.WriteLine();
            Console.WriteLine("Part 2:");
            Console.WriteLine("Enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 > 0)
            {
                for (int i = 1; i <= number1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine();
            Console.WriteLine("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sumNum2 = number2 * (number2 + 1) / 2;
            if (number2 > 0)
            {
                Console.Write("Formula: ");
                for (int i = 1; i <= number2; i++)
                {
                    
                    Console.Write(i);
                        if (i < number2)
                    {
                        Console.Write("+");
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Sum: {sumNum2}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine();
            Console.WriteLine("Enter a number:");
            int number3 = Convert.ToInt32(Console.ReadLine());
           
            if (number3 > 0)
            {
                for (int i = number3; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
                
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}



