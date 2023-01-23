using KESCHA.Classes;

Console.Write("Enter your name: ");
string name  = Console.ReadLine();
string greeting = $"Hello {name}";
Console.WriteLine(greeting);

Console.Write("Enter your age: ");
string ageAsString = Console.ReadLine();
Console.WriteLine("Converting..... ");
int age = int.Parse(ageAsString);
Console.WriteLine($"Successfully converted! {age}");
int keschasAge = 3;
int ageDifference = age - keschasAge;
Console.WriteLine($"The differenc between your and Kescha's age is {ageDifference}");




Animal animal = new Animal();
animal.ID = 1;
Console.WriteLine($"Animal Id number is: {animal.ID}");
animal.Name = "Kescha";
Console.WriteLine($"Animal name is: {animal.Name}");
