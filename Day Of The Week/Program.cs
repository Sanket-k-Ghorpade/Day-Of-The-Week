namespace Day_Of_The_Week
{
    internal class Program
    {
        // we have assigned a numeric value to Monday as 1,the following elements will follow accordingly
        enum DayOfWeek { Monday = 1 , Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        static void Main(string[] args)
        {
            Console.WriteLine("--------Day of the week---------\n");

            int day;
            //input validation
            do
            {
                Console.Write("Enter a number (1-7): ");
                day = int.Parse(Console.ReadLine());
                if (day < 1 || day > 7) Console.WriteLine("Invalid input! Please enter again\n");
            }
            while (day < 1 || day > 7);

            // accessing the enum values using the assigned numerical value (day)
            Console.WriteLine($"Day is: {(DayOfWeek)day}");
        }
    }
}
