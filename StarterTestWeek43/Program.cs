// See https://aka.ms/new-console-template for more information
using StarterTestWeek43;


Console.WriteLine("------------------- Del 1 --------------------");

Console.WriteLine("Opgave 1");

//TODO: Opgave 1
// Lav et For loop som udskriver tallene fra og med 15 til og med 25

for (int i = 15; i < 26; i++)
{
    Console.Write(i +" ");
}


Console.WriteLine("\nSlut på opgave 1");


Console.WriteLine("\nOpgave 2");
//TODO: Opgave 2
// Lav et WHILE loop som udskriver tallene fra og med 15 til og med 25
int t = 15;
while (t <= 25)
{
    Console.Write(t+" ");
    t++;
}

Console.WriteLine("\nSlut på opgave 2");


Console.WriteLine("\nOpgave 3");
//TODO: Opgave 3
// Lav et FOR loop som beregner summen af tallene fra og med 15 til og med 25

int sum = 0;

for (int i = 15; i < 26; i++)
{
    sum = sum + i;
}


Console.WriteLine($"Summen af tallene fra og med 15 til og med 25 er : {sum}");
Console.WriteLine("Slut på opgave 3");



Console.WriteLine("\nOpgave 4");
// TODO: Opgave 4
// Lav et FOREACH loop som udskriver tallene i listOfInt


List<int> listOfInt = new List<int>();
listOfInt.Add(4);
listOfInt.Add(12);
listOfInt.Add(9);
listOfInt.Add(5);
listOfInt.Add(12);
listOfInt.Add(2);

foreach (int i in listOfInt)
{
    Console.Write(i+" ");
}


Console.WriteLine("\nSlut opgave 4");

Console.WriteLine("\nOpgave 5");
// TODO: Opgave 5
// Lav et FOR loop som beregner summen som af tallene i listOfInt

int listSum = 0;


for (int i = 0; i < listOfInt.Count; i++)
{
   
    listSum = listSum + listOfInt[i];
}



Console.WriteLine($"Summen af tallene i listOfInt: {listSum}");

Console.WriteLine("Slut opgave 5");

Console.WriteLine("\nOpgave 6");
// TODO: Opgave 6
// Lav et loop som undersøger om tallet i variablen searchNumber findes i listOfInt
// Hvis tallet i searchNumber findes skal det udskrives at det findes. 
// Hvis tallet ikke findes skal det udskrives at searchNumber ikke findes


int searchNumber = 5;

bool found = false;
int k = 0;
foreach (int i in listOfInt)
{
    if (i == searchNumber)
    {
         
        found = true;
        break;
    }
    
    k++;
}
if (found == true)
{
    Console.WriteLine($"number {searchNumber} found");
}
else
{
    Console.WriteLine("not found");
}

Console.WriteLine("Slut opgave 6");


Console.WriteLine("\nOpgave 7");
// TODO: Opgave 7
// Lav et loop som beregner hvor mange gange tallet i variablen aNumber findes i listOfInt
// Antallet skal opsamles i variablen countOfaNumber


int aNumber = 12;
int countOfaNumber = 0;


foreach (int i in listOfInt)
{
    if (i == aNumber)
    {
        countOfaNumber++;
    }
}

Console.WriteLine($"{aNumber} found {countOfaNumber} times in listOfInt");

Console.WriteLine("Slut opgave 7");



Console.WriteLine("------------------- Del 2 --------------------");

Console.WriteLine("Welcome to Music-World!");

Musician m1 = new Musician("Jimi Hendrix", "Guitar street 123", 10);

Instrument i1 = new Instrument(1, "Guitar");
Instrument i2 = new Instrument(2, "Tværfløjte");

Console.WriteLine("\nOpgave 8");

// TODO: Opgave 8
// Lav sætninger i metoden AddInstrument
bool addedInstrument1 = m1.AddInstrument(i1);
if (addedInstrument1)
{
    Console.WriteLine($"Instrumentet id {i1.Id} navn {i1.Name} er tilføjet til musikeren");
}
bool addedInstrument2 = m1.AddInstrument(i2);
if (addedInstrument2)
{
    Console.WriteLine($"Instrumentet id {i2.Id} navn {i2.Name} er tilføjet til musikeren");
}
Console.WriteLine("Slut opgave 8");

Console.WriteLine("\nOpgave 9");
// TODO: Opgave 9
// Lav sætninger i metoden Tostring der udskriver alle oplysninger om musikeren og alle instrumenter
Console.WriteLine(m1.ToString());
Console.WriteLine("Slut opgave 9");
