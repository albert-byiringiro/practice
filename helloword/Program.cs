// See https://aka.ms/new-console-template for more information

// --- topics - Strings
Console.WriteLine("Hello, World!");

string firstFriend = "   Roger ";
string secondFriend = "Innocent";
string friends = $"My friends are {firstFriend.Trim()} and {secondFriend.ToUpper()}";
Console.WriteLine(friends.Replace("Innocent", "Love"));

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

// StartWith and EndsWith
Console.WriteLine(songLyrics.StartsWith("You"));

// String interpolation

var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

// Output:
// Jupiter Hammon was an African American poet born in 1711.
// He was first published in 1761 at the age of 50.
// He'd be over 300 years old today.


// -- Numbers
// -- integer

int a = 18;
int b = 19;
int c = a + b;
Console.WriteLine(c);

// -- testing order of operations
int a2 = 5;
int b2 = 4;
int c2 = 2;
int d = a2 + b2 * c2;
Console.WriteLine(d);

// int (min and max values)

// int max = int.MaxValue;
// int min = int.MinValue;
// Console.WriteLine($"The range of integers is {min} to {max}");

double a3 = 19;
double b3 = 24;
double c3 = 8;
double d3 = (a3 + b3) / c3;

Console.WriteLine(d3);

double third = 1.0 / 3.0;
Console.WriteLine(third);

double a4 = 1.0;
double b4 = 3.0;
Console.WriteLine(a4 / b4);

decimal c4 = 1.0M;
decimal d4 = 3.0M;
Console.WriteLine(c4 / d4);

// --- TOPICS - Other types
// -- Tuple