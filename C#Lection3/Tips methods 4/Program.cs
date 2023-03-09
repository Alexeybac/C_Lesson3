// 1 тип: Ничего не получает, Ничего не возвращает.

void method1()
{
    Console.WriteLine("Текст");
}
//method1();

//2 тип: Что-то получает, Ничего не получает.

void method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//method2(count: 8, msg: "Привет");

//3 тип: Ничего не получает, Что-то возвращает.

int method3()
{
    int rezult = new Random().Next(1,10);
    return rezult;
}
//Console.WriteLine(method3());

//4 тип: Что-то получает, Что-то возвращает.

string method4(string text, int count)
{
    int i = 0;
    string rez = string.Empty;
    while(i < count)
    {
        rez = rez + text;
        i++;
    }
    return rez;
}

//string rezult = method4("z", 110);
Console.WriteLine(method4("z", 110));