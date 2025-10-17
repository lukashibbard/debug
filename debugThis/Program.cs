/*
for a lot of it i just switched it from console.writeline(""+var) to console.writeline($"{var}")
*/
Console.WriteLine("Welcome to the Debugging Challenge!");
Console.Write("Enter your name: "); 
string name = Console.ReadLine() + "";
Console.WriteLine($"Hello {name}! Let's do some math."); 
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine()); 
// changed this one to convert.toint32
int result = 100 / number;
Console.WriteLine($"100 divided by your number is: {result}");
int remainder = 100 % number;
Console.WriteLine($"The remainder of 100 divided by your number is: {remainder}");
if (number == 10) 
// it only had one = it needed ==
{
    Console.WriteLine("You entered ten!");
}
else
{
    Console.WriteLine("You didn’t enter ten.");
}
int counter = 0;
while (counter < number)
{
    Console.WriteLine($"Counting up: {counter}");
    counter++; 
    //this said counter-- instead of ++
}
Console.WriteLine("Done counting!");
string again;
do
{
    Console.WriteLine("Do you want to see your number squared? (yes/no)");
    again = Console.ReadLine() + "";

    Console.WriteLine($"Your number squared is:{number * number}");
}
while (again == "yes"); 
//the do and while were flipped
for (int i = 5; i >= 0; i--) 
{
    Console.WriteLine($"Countdown: {i}");
}
int[] scores = new int[5];
scores[0] = 100;
scores[1] = 100 + number*number;
Console.WriteLine($"First score: { scores[0]}"); 
Console.WriteLine($"Last score: {scores[1]}");
List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
fruits.Remove("cherry"); 
//it was using a string not in the list
fruits.Add("Rasbarry"); 
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit.ToUpper());
}
Console.Write("Pick a number between 1 and 3: ");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine("You picked one!");
        break;
    case 2:
        Console.WriteLine("You picked two!");
        break;
    case 3:
        Console.WriteLine("You picked three!");
        break;
    default:
        Console.WriteLine("That’s not between 1 and 3!");
        break;
}


































































Console.WriteLine($"Thanks for debugging,  {name} !");
Console.WriteLine("Press Enter to exit.");

Console.ReadLine(); 
