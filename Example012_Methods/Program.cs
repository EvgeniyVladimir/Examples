﻿// Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор....");
// }
// Method1();




// Вид2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4);
// Method21(count: 4, msg: "новый текст");
//____________________________________________________

//Вид3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);
//____________________________________________________

// Вид4
// string Method4(int count, string text)  ///Работает, ниже то же самое но в другом исполнении
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
                                         /// См. выше. /Работает, то же самое но в другом исполнении 

// string Method4(int count, string text)  /// См. выше. /Работает, то же самое но в другом исполнении 
// {   
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);
// ____________________________________________________



// for (int i = 1; i <=10; i++)
// {
//     for (int j = 1; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// ____________________________________________________

//=======Работа с текстом.
//Дан текст. В тексте необходимо пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К".
// а большие "С" заменить маленькими"с".

// string text = "Текст (от лат. textus — ткань; сплетение, Сочетание)"
            // + "— зафиксированная на каком-либо материальном носителе человеческая мысль"
            // + "в общем плане связная и полная последовательность символов.";

// string s = "qwerty"
//             0123
// s[3] // r 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);

// ____________________________________________________

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);