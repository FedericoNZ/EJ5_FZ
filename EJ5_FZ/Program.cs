Console.WriteLine("Ingrese la longitud de su base de datos:");
int lBase = int.Parse(Console.ReadLine());
int[] baseDatos = new int[lBase];

Random numeros = new Random();
for(int i = 0; i < lBase; i++)
{
    baseDatos[i] = numeros.Next(100);
}

Console.WriteLine("\nValores de tu base de datos:");
for(int i = 0; i < lBase; i++)
{
    Console.WriteLine($"N°{i+1}: {baseDatos[i]}");
}

for(int i = 0; i < (lBase/2); i++)
{
    int aux = baseDatos[i];
    baseDatos[i] = baseDatos[lBase - 1 - i];
    baseDatos[lBase - 1 - i] = aux;
}

Console.WriteLine("\n========================================\n");
Console.WriteLine("\nValores de su base de datos invertidos:");
for (int i = 0; i < lBase; i++)
{
    Console.WriteLine($"N°{i + 1}: {baseDatos[i]}");
}

Console.ReadKey();