// Basic String Processing

using System.Collections.Generic;
List<string> UserSentence = new List<string>();

do
{
    Console.WriteLine( "Please enter a sentence below: " );
    var Value = Console.ReadLine();
    if (Value != null)
    {
        UserSentence = Value.Split(" ").ToList();
        foreach (string n in UserSentence)
        {
            Console.WriteLine(n);
        }
    }
    else
        break;
    Console.WriteLine("Would you like to continue: (y/n)? ");
    var UserAnswer = Console.ReadLine();
    if (UserAnswer != null)
    {
        if (UserAnswer.ToLower() == "n")
        {
            break;
        }
    }
    else
        break;

} while(true);