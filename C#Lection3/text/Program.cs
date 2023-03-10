string text = "А - роза упала, на  лапу азора";

string repleace (string text, char oldtext, char newtext)
{
    string rezult = String.Empty;
    int leng = text.Length;
    for (int i = 0; i < leng; i++)
    {
        if(text[i] == oldtext) rezult = rezult + $"{newtext}";
        else rezult = rezult + $"{text[i]}";
    }
    return rezult;
}

string ntext = repleace(text, ',', ' ');
//Console.WriteLine (ntext);
string stext = repleace(ntext, 'о', 'и');
//Console.WriteLine (stext);
string ttext = repleace(stext, 'р', 'Р');
Console.WriteLine (ttext);