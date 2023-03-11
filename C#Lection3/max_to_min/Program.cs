int [] arra = {1, 2, 4, 6, 8, 9, 12, 143, 200, 6, 1, 2};


void sorting(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int rev = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[rev]) rev = j;
        }
        int resort = array[i];
        array[i] = array[rev];
        array[rev] = resort;
    }
}

void printaray(int [] aray)
{
    for(int i = 0; i < aray.Length; i++)
    {
        Console.Write($"{aray[i]} ");
    }
    Console.WriteLine();
    }

printaray(arra);
sorting(arra);
printaray(arra);