

using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
	Console.WriteLine(new Date(2024, 02, 29));
	Console.WriteLine(new Date(1974, 11, 30));
	Console.WriteLine(new Date(2022, 04, 05));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}