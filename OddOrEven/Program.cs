while (true)
{

    Console.WriteLine("Eneter a number");
    string userInput = Console.ReadLine();
    if (userInput == "done")
    {
        break;
    }
    int num = 0;
    bool isNum = Int32.TryParse(userInput, out num);
    Console.WriteLine(userInput);
    int even = num % 2; 
    if (isNum == false)
    {
        continue;
    }
    else 
    {
        if (even == 0)
        {
            Console.WriteLine($"This number: {userInput} is even");
            continue;
        }
        else
        {
            Console.WriteLine($"This number: {userInput} is odd");
            continue;
        }
    }
 
}
