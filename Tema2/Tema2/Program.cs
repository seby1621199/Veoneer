class Program
{
    #region Ex1

    static int[] ShowReverseOrderArray(int n)
    {
        Console.WriteLine("Introduceti numerele: ");
        var arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nReverse Order\n");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
        return arr;
    }

    static void PrintSumElements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine($"\nSuma este: {sum}\n");

    }

    static void OccurenceOfElement(int[] array, int element)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                count++;
            }
        }

        Console.WriteLine($"\nNumarul {element} apare de {count} ori.\n");

    }

    static void PrintUniqueElements(int[] array)
    {
        Console.WriteLine("\nNumerele unice sunt: ");
        for (int i = 0; i < array.Length; i++)
        {
            bool ok = true;
            for (int j = 0; j < array.Length; j++)
            {
                if (i != j && array[i] == array[j])
                {
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                Console.Write(array[i]+" ");
            }
        }
        Console.WriteLine("\n");

    }


    #endregion

    #region Ex2
    static int[,] AddMatrix(int[,] a, int[,] b)
    {
        int n = a.GetLength(0);
        int[,] c = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }
        return c;
    }

    static void ShowMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }


    }

    static int AddOnDiagonals(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    sum += matrix[i, j];
                }
                if (i + j == n - 1)
                {
                    sum += matrix[i, j];
                }
            }
        }
        return sum;
    }
    #endregion

    #region Ex3
    //Write a function that takes two sorted arrays of same size and merge them in ascending order. (DO NOT USE LINQ)
    static int[] SortSameSizeAndBothSorted(int[] a, int[] b)
    {
        var sorted = new int[a.Length * 2];
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < a.Length && j < b.Length) //cat timp avem elemente si in a si in b
        {
            if (a[i] < b[j])
            {
                sorted[k++] = a[i++];
            }
            else
            {
                sorted[k++] = b[j++];
            }
        }

        while (i < a.Length)
        {
            sorted[k++] = a[i++]; //adaugam ce o mai ramas in a
        }

        while (j < b.Length)
        {
            sorted[k++] = b[j++]; //adaugam ce o mai ramas in b
        }

        return sorted;
    }
    //b - Add a function to insert elements into the array after the merge. Array must remain sorted.
    static int[] InsertElementInSortedArray(int[] a, int element)
    {

        var sorted = new int[a.Length + 1];
        int i = 0;
        int j = 0;
        while (i < a.Length && a[i] < element) //parcurgem arr pana gasim un element mai mare ca el
        {
            sorted[j++] = a[i++];
        }
        sorted[j++] = element;
        while (i < a.Length)
        {
            sorted[j++] = a[i++];
        }
        return sorted;
    }

    #endregion

    #region Ex4
    static bool CheckDigitInArray(ulong[] a, byte element) // fara string
    {
        foreach (int i in a)
        {
            int j = i;
            while (j != 0)
            {
                if (j % 10 == element)
                    return true;
                j = j / 10;
            }
        }
        return false;
    }

    static bool CheckDigitInArray2(ulong[] a, byte element)
    {
        foreach (int i in a)
        {
            if (i.ToString().Contains(element.ToString()))
                return true;
        }

        return false;
    }

    #endregion

    #region Ex5

    static string FindPattern(List<string> list, string pattern)
    {
        return list.FirstOrDefault(_ => _.Contains(pattern));
    }

    #endregion

    #region Ex6

    static void Reverse(List<int> list)
    {
        list.Reverse();
        foreach (var s in list)
            Console.WriteLine(s);
    }

    static int SumWithLINQ(List<int> list)
    {
        int sum = 0;
        list.ForEach(x => sum += x);
        return sum;
    }

    static int OccurenceWithLINQ(List<int> list, int number)
    {
        return list.Count(_ => _ == number);
    }

    static List<int> UniqueWithLINQ(List<int> list)
    {
        return list.GroupBy(x => x)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key).ToList();

    }

    #endregion

    #region Ex7

    static List<int> MergeList(List<int> list1, List<int> list2)
    {

        return list1.Concat(list2).OrderBy(x => x).ToList();
    }

    static List<int> InsertIntoList(List<int> list, int element)
    {
        list.Add(element);
        return list.OrderBy(x => x).ToList();


    }

    #endregion


    static void Main()
    {
        #region Ex1
        //Write a function to read n number of values in an array and display it in reverse order. N is also read as input. ( DO NOT USE LINQ )
        Console.WriteLine("Introduceti dimensiunea:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        arr = ShowReverseOrderArray(n);

        //Print sum of elements.
        int sum = 0;
        PrintSumElements(arr);

        //Print occurence of specific number.
        OccurenceOfElement(arr, 1);

        //Print all unique elements.
        PrintUniqueElements(arr);
        ////pentru toate numerele si >9 iar pentru un arr de contine numere si <=9 este rezolvat in timpul meet-ului
        #endregion

        #region Ex2 main

        //int[,] A = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //int[,] B = new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };


        //Adunarea Matriciolor

        //int[,] C = AddMatrix(A, B);
        //ShowMatrix(C);


        //Suma pe diagonala principala+secundara
        //Console.WriteLine($"Suma diagonalelor este:{AddOnDiagonals(C)}");


        #endregion

        #region Ex3 main

        //int[] array1 = { 1, 3, 5, 7 };
        //int[] array2 = { 2, 4, 6, 8 };

        //int[] sortedArray = SortSameSizeAndBothSorted(array1, array2);

        //Console.WriteLine("\nArray-ul sortat rezultat este:");
        //foreach (int element in sortedArray)
        //{
        //    Console.Write(element + " ");
        //}

        //int[] array3 = InsertElementInSortedArray(array1, 4);
        //Console.WriteLine("\nArray-ul rezultat dupa inserarea elementului 4 este:");
        //foreach (int element in array3)
        //{
        //    Console.Write(element + " ");
        //}


        #endregion

        #region Ex4 main

        //ulong[] a = { 1, 11211,3, 4, 5, 6, 7, 8, 9, 10 };
        //byte b = 2;

        //bool isPresent = CheckDigitInArray(a, b); //prin mod la 10
        //isPresent = CheckDigitInArray2(a, b); //cu string
        //Console.WriteLine(isPresent);

        #endregion

        #region Ex5 main

        //List<string> list = new List<string>() { "salut", "test", "balaur" };
        //string test=FindPattern(list, "aur");
        //Console.WriteLine(test);

        #endregion

        #region Ex6 main

        List<int> list = new List<int>() { 1, 2, 3, 1 };

        //Reverse(list);

        //Console.WriteLine(SumWithLINQ(list));

        //Console.WriteLine(OccurenceWithLINQ(list, 1));

        /*
        foreach (int i in UniqueWithLINQ(list))
            Console.WriteLine(i);
        */
        #endregion

        #region Ex7 main

        //List<int> list1= new List<int>() { 1,2,3,4,7};
        //List<int> list2= new List<int>() { 6,8,9,10};


        //Console.WriteLine("\nMergeList\n");
        //foreach (int i in MergeList(list1, list2))
        //    Console.Write(i +" ");


        //Console.WriteLine("\nInsert element\n");
        //int element = 5;
        //foreach (int i in InsertIntoList(MergeList(list1, list2), element))
        //    Console.Write(i+" ");

        #endregion


    }
}