// Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор....");
// }
// Method1();




// Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
Method21(count: 4, msg: "новый текст");


//Вид3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

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

string Method4(int count, string text)  /// См. выше. /Работает, то же самое но в другом исполнении 
{   
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);