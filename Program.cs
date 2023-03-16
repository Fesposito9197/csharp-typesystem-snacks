
//snack1();
snack2();



void snack1()
{
    Console.WriteLine("Inserisci il primo numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Inserisci il secondo numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine("il numero maggiore e: {0}" ,num1);
    }
    else
    {
        Console.WriteLine("il numero maggiore e: {0}", num2);
    }
}

void snack2()
{
    Console.WriteLine("Inserisci la prima parola: ");

    string firstWord = Console.ReadLine()?? "";

    Console.WriteLine("inserisci la seconda parola: ");

    string secondWord = Console.ReadLine() ?? "";

    if (firstWord.Length > secondWord.Length)
    {
        Console.WriteLine(firstWord);
        Console.WriteLine(secondWord);
    }
    else
    {
        Console.WriteLine(secondWord);
        Console.WriteLine(firstWord);
    }
}