

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

    if (Hunger == 1)
    {
        Console.WriteLine("I WILL NOT EAT anymore food. I wanna play or just allow me to take rest!");
    }
    if (Hunger == 3 || Hunger == 2)
    {
        Console.WriteLine("Dont feed your pet " + petname + " He is full. Play with your pet or make him take rest!");
    }
    else if (Hunger > 8)
    {
        Console.WriteLine("Your pet " + petname + " is very Hungry. Feed Him!!!");
    }




    //Extreme Conditions for Happiness
    if (Happiness == 3 || Happiness == 2)
    {
        Console.WriteLine("Your pet " + petname + " is not happy. Play with him or Feed him!");
    }
    if (Happiness == 1)
    {
        Console.WriteLine("I don't wanna take rest anymore. I wanna play or just feed me!");
    }
    else if (Happiness > 8)
    {
        Console.WriteLine("Your pet " + petname + " is extremely happy. Let him rest for some time.");
    }


    //Extreme Conditions for Health
    if (Health == 2 || Health == 2)
    {
        Console.WriteLine("Your pet " + petname + " is not healthy. Feed him or make him rest!");
    }
    if (Health == 1)
    {
        Console.WriteLine("I WILL NOT PLAY anymore. I want to take rest or just feed me.");
    }
    else if (Health > 8)
    {
        Console.WriteLine("Your pet " + petname + "is extremely healthy. Play with him!");
    }

}
while (userinput != 5); // exit condition