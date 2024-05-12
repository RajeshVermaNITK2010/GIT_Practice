// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

byte b1 = 1;
byte b2 = 2;
var sum = b1 + b2;
Console.WriteLine(sum);

Employee user1 = new Manager();
Console.WriteLine("${0}: {1} :", user1.Bonus, user1.GetType().Name);
Console.WriteLine("${0}: {1} : {2}", user1.Bonus, user1.GetType().Name, user1.GetType());