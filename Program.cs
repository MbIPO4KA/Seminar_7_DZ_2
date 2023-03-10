/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1(строчка) 7 (столбец) -> такого числа в массиве нет*/



// Создаём метод
Console.WriteLine("Зададим количество строк в двумерном массиве ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Зададим количество столбцов в массиве ");
int cols= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Зададим минимальное число в матрице ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Зададим маексимальное число в матрице ");
int maxValue= Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix()
//int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    
    int[,] matrix = new int[rows, cols];// Создаём матрицу

    // теперь ЗАПОЛНЯЕМ двумерный массив    
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {        
        for (int j = 0; j < matrix.GetLength(1) ; j++)  
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);// рандомное число в каком-то диапозоне
        }
    }
    return matrix;  // вернули заполненную табличку
}
 // Для того, чтобы увидеть это на экране создаём метод void
 void PrintMatrix(int[,]matr)
 {
    for (int i = 0; i < matr.GetLength(0); i++) // проход по всем строчкам    
    {
         for (int j = 0; j < matr.GetLength(1); j++) // проход по всем столбцам     
        {
            Console.Write(matr[i,j] + "\t"); //  печать строки с 4 пробелами между цифрами
        }
        Console.WriteLine();
    }
 }
//Вызовем наш метод

// первым делом нужно создать массив
// Создание массива - это метод под названием GetMatrix 
// Создаем двумерный массив
// в нашу таблицу resultMatrix должна попасть заполненная таблица с числами от min до max
// чтобы esultMatrix заполнилась значениями мы вызываем метод GetMatrix и в скобках указываем параметры
int[,] resultMatrix = GetMatrix(); 

Console.WriteLine(" У нас получилась вот такая матрица ");
PrintMatrix(resultMatrix); // Печать матрицы полностью

Console.WriteLine(" ");

Console.WriteLine(" Напишите  позиции элемента в двумерном массиве ");
Console.WriteLine(" Напишите  номер строки:  ");
int rows1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Напишите  номер столбца:  ");
int cols1= Convert.ToInt32(Console.ReadLine());


if(rows > rows1 || cols > cols1)
{
Console.WriteLine($" значение этого элемента  {resultMatrix[ rows1 ,  cols1] }");
}
else
{
    Console.WriteLine($" Нет такой буквы в этом слове ");
}

// Сама понимаю, что костыльно, масло - масленое, но не смогла понять, как 
//сравнивать с данными, если их прописать в методе int[,] resultMatrix = GetMatrix(3, 4, 1, 10 ); 