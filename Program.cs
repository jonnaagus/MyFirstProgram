namespace MyFirstProgram
{
    // Skapad av: Jonna Gustafsson
    // Klass: .NET23

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a variable and store a number
            int myNumber = 15;

            // Check if the value in the variable is above 10
            if (myNumber > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            // Ask the user for their name and store it in a variable
            Console.WriteLine("Vad heter du?");
            string userName = Console.ReadLine();

            // Write "Hej" to the user and write the users name
            Console.WriteLine("Hej " + userName + "!");

            // Loop to print all numbers from 0 up to the value in the previous variable
            // Use a for-loop to count from 0 to myNumber
            int numbers = 15;
            Console.WriteLine("Här är alla tal från 0 till " + numbers + ":");
            for (int i = 0; i <= numbers; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}