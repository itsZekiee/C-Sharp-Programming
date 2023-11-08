// See https://aka.ms/new-console-template for more information
using Coding_Challenge_One_Validation;

bool continueProgram = true;

while (continueProgram)
{
    Console.WriteLine("\n|| =========== || CODING CHALLENGE ONE: VALIDATION || =========== ||");
    Console.Write("Enter an integer number:\t");
    string input = Console.ReadLine();

    ValidationClass validator = new ValidationClass();

    if (validator.isEmptyValue(input))
    {
        Console.WriteLine("Error message: Invalid value! You must enter a value.\n");
    }
    else if (validator.isNonNumericValue(input))
    {
        Console.WriteLine("Error message: Invalid value! You must enter a numeric value.\n");
    }
    else if (validator.isNonIntegerValue(input))
    {
        Console.WriteLine("Error message: Invalid value! You must enter an integer value.\n");
    }
    else
    {
        int number = int.Parse(input);
        SignClass signer = new SignClass();
        string result = signer.detSignValue(number);
        Console.WriteLine("Result:" + "\t" + result);
    }

    Console.Write("Do you want to try again? (Yes/No): ");
    string tryAgain = Console.ReadLine();

    if (tryAgain.Equals("No", StringComparison.OrdinalIgnoreCase))
    {
        continueProgram = false;
    }
}

Console.WriteLine("Thank you and Goodbye!\n");
