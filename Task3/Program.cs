/*
Arrays are always fixed in size, you cannot add or remove items from array. 

Lists are Dynamic in size and you can add or remove items from a list.

Dictionaries work with key and value pairs. Key must be unique and you can use it to access the value. also dynamic you can add or remove pairs.
 */

// Arrays 
Console.WriteLine();
Console.WriteLine("Arrays --------------");

string[] metalsArray = ["Gold", "Silver", "Copper", "Iron", "Aluminum"];
int[] atomicNumbersArray = [79, 47, 29, 26, 13];
double[] meltingPointsArray = [1064, 961.8, 1085, 1538, 660.3];

for (int i = 0; i < metalsArray.Length; i++)
{
    Console.WriteLine($"The atomic number of {metalsArray[i]} is {atomicNumbersArray[i]} and its melting point is {meltingPointsArray[i]} °C");
}
foreach (var number in atomicNumbersArray)
{
    Console.WriteLine(number);
}


// List
Console.WriteLine();
Console.WriteLine("Lists ------------");

List<string> metals = ["Gold", "Silver", "Copper", "Iron", "Aluminum"];
List<int> atomicNumbers = [79, 47, 29, 26, 13];
List<double> meltingPoints = [1064, 961.8, 1085, 1538, 660.3];

for (int i = 0; i < metals.Count; i++)
{
    Console.WriteLine($"The atomic number of {metals[i]} is {atomicNumbers[i]} and its melting point is {meltingPoints[i]} °C");
}

foreach (var metal in metals)
{
    Console.WriteLine(metal);
}


// Dictionaries
Console.WriteLine();
Console.WriteLine("Dictionaries ------------");

// Capitals
Dictionary<string, string> Capitals = new()
{
    {"Japan", "Tokyo"},
    {"Norway", "Oslo"},
};

Capitals.Add("Thailand", "Bangkok");

foreach (var entry in Capitals)
{
    Console.WriteLine($"The Capital in {entry.Key} is {entry.Value}");
}

for (int i = 0; i < Capitals.Count; i++)
{
    var entry = Capitals.ElementAt(i);
    Console.WriteLine($"The Capital in {entry.Key} is {entry.Value}");
}


// Population
Dictionary<string, double> Population = new()
{
    {"Japan", 123.2},
    {"Norway", 5.66},
};
Population.Add("Thailand", 65.8);

for (int i = 0; i < Population.Count; i++)
{
    var entry = Population.ElementAt(i);
    Console.WriteLine($"The population in {entry.Key} is {entry.Value} million");
}

Console.ReadKey();