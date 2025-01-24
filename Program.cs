using System; // This is a namespace that contains the Console class allows us to write to the console using various methods like variable interpolation, string concatenation, etc.

namespace HelloWorld // This is a namespace that contains the Program class. Namespaces are used to organize code and prevent naming conflicts.
{
    class Program // This is a class that contains the Main method. The Main method is the entry point of the program.
    {
        static void Main(string[] args) // This is the entry point of the program. The Main method is the first method that gets called when the program is run.
        {
            Console.WriteLine("Hello My Name is Shane Cummings!"); // This is a method that writes the string "Hello World!" to the console.
            Console.WriteLine("My Banner ID is B01740631.");

            // string Firstname = "Shane"; // This is a variable declaration. It declares a variable named "Firstname" of type string and assigns it the value "Shane".
            // string Lastname = "Cummings"; // This is a variable declaration. It declares a variable named "Lastname" of type string and assigns it the value "Cummings".

            // Console.WriteLine($"My first name is {Firstname} and my last name is {Lastname}."); // This is a method that writes a string to the console. It uses variable interpolation to insert the values of the variables "Firstname" and "Lastname" into the string. Using the $ symbol before the string allows us to use variable interpolation.

            Console.WriteLine("What is your first name?"); // This is a method that writes a string to the console.
            string UserFirstname = Console.ReadLine(); // This is a method that reads a string from the console and assigns it to the variable "UserFirstname".

            Console.WriteLine($"Hello {UserFirstname}! How are you today?"); // This is a method that writes a string to the console. It uses variable interpolation to insert the value of the variable "UserFirstname" into the string.

            Console.Write("Press any key to exit...");//writeline is a method that writes a string to the console and moves to the next line, write is a method that writes a string to the console and stays on the same line
            Console.ReadKey(); // This is a method that waits for the user to press a key before exiting the program.
        }
    }
}

// run dotnet build after saving the file, BEFORE you Dotnet run!