

// APPLICATION TO MONITOR YOUR PET'S STATUS

// User allowed to choose their type of pet
Console.WriteLine(" Sush's Pet health APP \n Choose one of the pets below:\n 1. Dog \n 2. Cat \n 3. Chipmunk");
Console.Write("User selected: ");
int userinput = Convert.ToInt32(Console.ReadLine()); //  Reading the user input
Console.WriteLine();// New line


//User getting different prompts according to the option selected

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

Console.Write("User selected: ");



// User allowed to name their pet
string petname = Console.ReadLine();  //  Reading the user input
Console.WriteLine();
Console.WriteLine("Hi " + petname + "! Let me take good care of you");


// Default user status
int Hunger = 5;
int Happiness = 5;
int Health = 5;




// Printing the main menu after naming the pet until we exit the application
do
{   // Assigning the values of each action to to 10 if it increases from 10
    // Assigning the values of each action to to 1 if it reduces from 1

    if (Hunger < 1 || Hunger > 10)
    {
        if (Hunger < 1)
        {
            Hunger = 1;
        }
        else
        {
            Hunger = 10;
        }
    }

    if (Happiness < 1 || Happiness > 10)
    {
        if (Happiness < 1)
        {
            Happiness = 1;
        }
        else
        {
            Happiness = 10;
        }
    }

    if (Health < 1 || Health > 10)
    {
        if (Health < 1)
        {
            Health = 1;
        }
        else
        {
            Health = 10;
        }
    }
    Console.WriteLine(); // New line

    // Main Menu options
    Console.WriteLine("Main Menu:\n 1.Feed " + petname + "\n 2.Play with " + petname + "\n 3.Let " + petname + " Rest \n 4.Check " + petname + "'s Status \n 5.Exit");
    Console.Write("User selected: ");
    userinput = Convert.ToInt32(Console.ReadLine()); //  Reading the user input
    Console.WriteLine();  //New line



    // Feeding your pet
    if (userinput == 1)
    {
        Hunger = Hunger - 1;
        Health = Health + 1;
        Console.WriteLine("You fed " + petname + ". His hunger reduces slightly and health increases slightly.");
    }


    //Playing with your pet
    else if (userinput == 2)
    {
        Hunger = Hunger + 1;
        Happiness = Happiness + 1;
       
        Console.WriteLine("You played with " + petname + ".His hunger increases slightly and happiness increases.");
    }


    //Letting your pet rest
    else if (userinput == 3)
    {
        Happiness = Happiness - 1;
        Health = Health + 1;
        Console.WriteLine("You let " + petname + " to  rest. His happiness decreases slightly and health improves.");
    }


    //Checking your pet's status
    else if (userinput == 4)
    {
        Console.WriteLine(petname + "'s Status: ");
        Console.WriteLine("Hunger :" + Hunger);
        Console.WriteLine("Happiness:" + Happiness);
        Console.WriteLine("Health:" + Health);
    }


    // Exiting from the application
    if (userinput == 5)
    {
        Console.WriteLine("You can come again later " + petname + " . Thanks!");
        return;
    }



    //Extreme condition for hunger

    if (Hunger == 1)
    {
        Console.WriteLine("I WILL NOT EAT anymore food. I wanna PLAY!");
    }
    if (Hunger == 3 || Hunger == 2)
    {
        Console.WriteLine("Dont feed your pet " + petname + " He is full. Play with your pet!");
    }
    else if (Hunger > 9)
    {
        Console.WriteLine("Your pet " + petname + " is very Hungry. Feed Him!!!");
    }



    //Extreme Conditions for Happiness
    if (Happiness == 3 || Happiness == 2)
    {
        Console.WriteLine("Your pet " + petname + " is not happy. Play with him!");
    }
    if (Happiness == 1)
    {
        Console.WriteLine("I don't wanna take rest anymore. I wanna play!");
    }
    else if (Happiness > 8)
    {
        Console.WriteLine("Your pet " + petname + " is extremely happy.");
    }


    //Extreme Conditions for Health
    if (Health == 2 || Health == 3)
    {
        Console.WriteLine("Your pet " + petname + " is not healthy. Feed him or make him rest!");
    }
    if (Health == 1)
    {
        Console.WriteLine("I WILL NOT PLAY anymore. I want to take rest or just feed me.");
    }
    else if (Health > 8)
    {
        Console.WriteLine("Your pet " + petname + "is healthy.");
    }



}
while (userinput != 5); // exit condition