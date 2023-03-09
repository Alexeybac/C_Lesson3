string method4(string text, int count)
{
    string rez = string.Empty;
    for(int i = 0; i<count; i++)
    {
        rez = rez + text;
    }
    return rez;
}
Console.Write(method4("z", 110));