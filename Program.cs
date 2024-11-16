// Loop until the user provides a valid number
while (true)
{
    try
    {
        // Prompt the user to enter a number
        Console.WriteLine("Please enter a number:");

        // Read user input and convert it to an integer
        int number = int.Parse(Console.ReadLine());

        // Calculate and display the square of the number
        Console.WriteLine($"The square of the number is: {number * number}");

        // Exit the loop if the input is valid
        break;
    }
    catch (FormatException)
    {
        // Display an error message if the input is not a valid number
        Console.WriteLine("Invalid input! Please enter a valid number.");
    }
}

// End the program
Console.WriteLine("Program has ended. Press any key to exit...");
Console.ReadKey();