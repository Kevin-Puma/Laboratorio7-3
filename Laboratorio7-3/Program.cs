int añoInicio = 1900;
int añoFin = 2023;

Console.WriteLine("Años bisiestos desde 1900 hasta 2023");

for (int año = añoInicio; año <= añoFin; año++)
{
    if (EsAñoBisiesto(año))
    {
        Console.WriteLine(año);
    }
}

static bool EsAñoBisiesto(int año)
{
    return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
}
