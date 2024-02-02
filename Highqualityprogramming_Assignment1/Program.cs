// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Choose one of the pet below:\n 1. Dog \n 2. Cat \n 3. Chipmunk");
int userinput = Convert.ToInt32(Console.ReadLine());
if (userinput==1)
Console.WriteLine("You have selected Dog as your pet");
if (userinput == 2)
    Console.WriteLine("You have selected Cat as your pet");
if (userinput == 3)
    Console.WriteLine("You have selected Chipmunk as your pet");


