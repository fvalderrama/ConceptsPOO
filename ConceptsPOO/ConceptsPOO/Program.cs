// See https://aka.ms/new-console-template for more information

using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2022, 12, 7));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 45));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}



