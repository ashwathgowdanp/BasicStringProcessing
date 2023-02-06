// Repeatdly prompt user for entering the string and display
List<string> usersentence= new List<string>();

do
{
    Console.Write("Enter some text: ");
    var userstring = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(userstring) && (!string.IsNullOrEmpty(userstring)))
    {
        usersentence.Add(userstring);
        Console.Write("You have entered: ");
        foreach (string n in usersentence)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        Console.Write("Would you like to continue: (y/n)? ");
        var UserAnswer = Console.ReadLine();
        if (!string.IsNullOrEmpty(UserAnswer))
        {
            if (UserAnswer.ToLower() == "n")
            {
                Console.WriteLine("GoodBye!");
                break;
            }
            else
                continue;
        }
        else
            break;

    }
    else
        break;
       

    
        
}while(true);
