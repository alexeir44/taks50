int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    bool check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

// создание двумерного массива
int[,] CreateArray()
{
    Console.WriteLine("Сгенерирован следующий массив ");
    int n = new Random().Next(5,10);;
    int m = new Random().Next(5,10);
    int[,] matrix = new int[n, m];
    for (int i = 0; i<n; i++)
    {
        for (int j = 0; j<m; j++)
        {
            matrix[i,j] = new Random().Next(-9,10);
            if (matrix[i,j]<0)
                Console.Write(matrix[i,j]+" ");
            else
                Console.Write(" " + matrix[i,j]+" ");           
        }
    Console.WriteLine();
    }
    return matrix;
}

// Вывод двумерного массива
void FindElement(int[,] matrix)
{
    Console.Write("Введите номер строки искомого значения: ");
    int n = CorrectInput();
    Console.Write("Введите номер столбца искомого значения: ");
    int m = CorrectInput();
    if (n <= matrix.GetUpperBound(0)+1 && m <= matrix.GetUpperBound(1)+1)
        Console.Write($"Этот элемент = {matrix[(n-1),(m-1)]}");
    else
        Console.Write("Такой позиции не существует.");
}


//Код программы
int[,] twoDimensionalArray = CreateArray();
FindElement(twoDimensionalArray);