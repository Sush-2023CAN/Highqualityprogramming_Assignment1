Console.WriteLine("Choose one of the pet below:\n 1. Dog \n 2. Cat \n 3. Chipmunk");
int userinput = Convert.ToInt32(Console.ReadLine());//Read User Input from console
Console.WriteLine("User selected: " + userinput);
if (userinput == 1)
{
    Console.WriteLine("You have selected Dog as your pet. What do you wanna name it?");
}
else if (userinput == 2)
{
    Console.WriteLine("You have selected Cat as your pet. What would you wanna name it?");
}

else if (userinput == 3)
{
    Console.WriteLine("You have selected Chipmunk as your pet. What would you wanna name it?");
}
string petname = Console.ReadLine();//Read the pet name 
Console.WriteLine(" User input :" + petname);
Console.WriteLine("Hi " + petname + " Let me take good care of you");

//Setting default Values

int Hunger = 5;
int Happiness = 5;
int Health = 5;

do
{
    Console.WriteLine("Main Menu:\n 1.Feed " + petname + "\n 2.Play with " + petname + "\n 3.Let " + petname + " Rest \n 4.Check " + petname + "'s Status \n 5.Exit");
    userinput = Convert.ToInt32(Console.ReadLine());   //  Reading the user input
    Console.WriteLine("User selected: " + userinput); // Printing the user input data

    // Feeding your pet
    if (userinput == 1)
    {
        Hunger = Hunger - 1;
        Happiness = Happiness + 1;
        Health = Health + 1;
        Console.WriteLine("You fed " + petname + ". His hunger reduces slightly, happiness and health increases gradually");
    }

    //Playing with your pet
    else if (userinput == 2)
    {
        Hunger = Hunger + 1;
        Happiness = Happiness + 1;
        Health = Health - 1;
        Console.WriteLine("You played with " + petname + ".His Health Reduces slightly,  happiness and hunger increases rapidly");
    }

    //Letting your pet rest
    else if (userinput == 3)
    {
        Hunger = Hunger + 1;
        Happiness = Happiness - 1;
        Health = Health + 1;
        Console.WriteLine("You let " + petname + " to  rest. His happiness reduces slightly, his hunger and health increases a bit");
    }

    //Checking your pet's status
    else if (userinput == 4)
    {
        Console.WriteLine(petname + "'s Status: ");
        Console.WriteLine("Hunger :" + Hunger);
        Console.WriteLine("Happiness:" + Happiness);
        Console.WriteLine("Health:" + Health);
    }

    // Exiting option
    else if (userinput == 5)
    {
        Console.WriteLine("You can come again later " + petname + " . Thanks!");
    }
}
while (userinput != 5); // exit condition