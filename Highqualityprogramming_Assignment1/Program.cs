﻿Console.WriteLine("Choose one of the pet below:\n 1. Dog \n 2. Cat \n 3. Chipmunk");
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
string petname = Console.ReadLine();
Console.WriteLine(" User input :" + petname);
Console.WriteLine("Hi " + petname + " Let me take good care of you");


