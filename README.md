# Try-Catch Practice: Simple Number Validation Program

This is a C# Console Application designed to demonstrate the use of `try-catch` for handling exceptions. The program prompts the user to enter a number, validates the input, and calculates the square of the number if the input is valid. If the input is invalid, it displays an error message and prompts the user again.

## Features

1. **Input Validation**: Ensures that the user enters a valid number.
2. **Exception Handling**: Uses a `try-catch` block to catch and handle invalid inputs (e.g., letters or symbols instead of numbers).
3. **Square Calculation**: Displays the square of the valid number entered by the user.
4. **Looping Mechanism**: Repeats the input prompt until the user provides a valid number.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- Basic understanding of C# programming, particularly `try-catch` blocks and exception handling.

## How to Run

1. Clone this repository or download the source code.
2. Open the project in your favorite IDE (e.g., Visual Studio, Visual Studio Code).
3. Build and run the application.

### Running the Program

1. When prompted, enter a number.
2. If the input is valid, the program will display the square of the number.
3. If the input is invalid (e.g., a letter or symbol), the program will show an error message and ask for input again.
4. The program ends after a valid number is entered and processed.

## Example Usage

### Valid Input

Please enter a number: 5 The square of the number is: 25 Program has ended. Press any key to exit...

### Invalid Input

Please enter a number: abc Invalid input! Please enter a valid number. Please enter a number: 7 The square of the number is: 49 Program has ended. Press any key to exit...

## Project Structure

Program.cs // Contains the main logic of the application


## Concepts Demonstrated

1. **Exception Handling**:
   - Demonstrates the use of `try-catch` blocks to handle `FormatException` errors.

2. **Input Validation**:
   - Ensures the user enters valid data before proceeding with calculations.

3. **Looping for Robustness**:
   - Provides a continuous prompt for input until the user complies with the expected format.

## Contribution

Feel free to fork the repository, make improvements, and submit a pull request. Contributions are always welcome!

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Author

Created by Batuhan Uzun
