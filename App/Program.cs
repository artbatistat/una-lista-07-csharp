int[] vetor = {1,100,30,50,11,13,5,7,78};

static void InsertionSort(int[] arr)
{
    int tamanhoVetor = arr.Length;

    for(int i = 1; i < tamanhoVetor; i++)
    {
        int key = arr[i];
        int j = i - 1;

        while(j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        
        arr[j + 1] = key;
    }
}

static void ImprimirVetor(int[] arr)
{
    foreach(var num in arr)
    {
        Console.WriteLine(num + " ");
    }
    
    Console.WriteLine();
}

static void ShellSort(int[] arr)
{
    int tamanhoVetor = arr.Length;

    for(int gap = tamanhoVetor / 2; gap > 0; gap /= 2)
    {
        for(int i = gap; i < tamanhoVetor; i++)
        {
            int temp = arr[i];

            int j;

            for(j = 1; j >= gap && arr[j-gap] > temp; j-=gap)
            {
                arr[j] = arr[j-gap];
            }

            arr[j] = temp;
        }
    }
}


Console.WriteLine("Digite qual função você quer executar \n 1 -  Insertion Sort Function \n 2 - Shell Sort Function");
int choose = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Array original:");
        ImprimirVetor(vetor);

switch(choose)
{
    case 1:
        InsertionSort(vetor);
        Console.WriteLine("Array ordenado:");
        ImprimirVetor(vetor);
    break;
    case 2:
        ShellSort(vetor);
        Console.WriteLine("Array ordenado:");
        ImprimirVetor(vetor);
    break;
    default:
        Console.WriteLine("Escolha incorreta!");
    break;
}

