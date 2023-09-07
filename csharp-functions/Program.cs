// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }

    Console.WriteLine("]");

};
int Quadrato(int numero)
{
    int quadrato = numero * numero;
    return quadrato;
};


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();

    for(int i = 0;i<arrayCopy.Length;i++ )
    {
        arrayCopy[i] = Quadrato(arrayCopy[i]);
    }
    for (int x = 0; x < arrayCopy.Length; x++)
    {

        Console.WriteLine(arrayCopy[x]);
    }
    for (int j = 0; j < arrayCopy.Length; j++)
    {

        Console.WriteLine(array[j]);
    }

    return arrayCopy;
};
int sommaElementiArray(int[] array)
{
    int sum = 0;
    for(int i = 0;i<array.Length ; i++) {
    
    sum += array[i];
    }    Console.WriteLine(sum);
    return sum;

}

//fine function d'appoggio

int[] exerciseArray = { 2, 6, 7, 5, 3, 9 };

StampaArray(exerciseArray);
ElevaArrayAlQuadrato(exerciseArray);
sommaElementiArray(exerciseArray);
