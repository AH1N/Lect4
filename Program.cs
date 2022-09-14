/*ДВУМЕРНЫЕ МАССИВЫ*/

/*ДВУМЕРНЫЕ МАССИВ - СТРОКА*/

// string[,] table = new string[2,5]; // table[0,0] -----table[1,4] 

// table[1,2] = "text1/2";

// for(int i = 0; i < 2; i++)
// {
//     for(int j = 0; j < 5; j++)
//     {
//         System.Console.WriteLine($" --{table[i,j]}--");
//     }

// }

/*ДВУМЕРНЫЕ МАССИВ - число-----------------------------------------------------------------------------------------*/

// int[,] matrix = new int[3,4]; // matrix[0,0] -----matrix[1,4] 

// matrix[1,2] = 1;

// for(int i = 0; i < matrix.GetLength(0); i++)  // то же самое, что и for(int i..; i < 2(тут длинна строки); i++);
// {
//     for(int j = 0; j < matrix.GetLength(1); j++) // то же самое, что и for(int j..; j < 3(тут длинна строки); j++);
//     {
//         System.Console.Write($"{matrix[i,j]} ");
//     }
//     System.Console.WriteLine();
// }

/*ДВУМЕРНЫЕ МАССИВ - МЕТОД число----------------------------------------------------------------------------------*/

 // matrix[0,0] -----matrix[1,4] 


// void PrintArray(int[,] m)
// {
//     for(int i = 0; i < m.GetLength(0); i++)  // то же самое, что и for(int i..; i < 2(тут длинна строки); i++);
//     {
//         for(int j = 0; j < m.GetLength(1); j++) // то же самое, что и for(int j..; j < 3(тут длинна строки); j++);
//         {
//             System.Console.Write($"{m[i,j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }


// void FillArray(int[,] m)
// {
//     for(int i = 0; i < m.GetLength(0); i++)  
//     {
//         for(int j = 0; j < m.GetLength(1); j++) 
//         {
//             m[i,j] = new Random().Next(0,10);
//         }    
//     }
// }

// int[,] matrixx = new int[3,4];

// PrintArray(matrixx);

// FillArray(matrixx);
// System.Console.WriteLine();

// PrintArray(matrixx);

/* РЕКУРСИЯ-------------------------------------------------------------------------------------------------------*/

// double Factorial(int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// System.Console.WriteLine(Factorial(3));

// for(int i = 1; i < 26; i++)
// {
//     System.Console.WriteLine($"{i}! {Factorial(i)}");
// }


/*ФИБОНАЧЧИ-------------------------------------------------------------------------------------------------------*/

// f(1) = 1;
// f(2) = 1;
// f(n) = f(n-1) + f(n-2);

// double Fibo(int n)
// {
//    if(n == 1 || n == 2) return 1;
//    else return Fibo(n-1) + Fibo(n-2); 
// }

// for(int i = 1; i < 10; i++)
// {
//     System.Console.WriteLine(Fibo(i));
// }

