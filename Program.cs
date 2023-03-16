
//snack1();
//snack2();
//snack3();
snack4();


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

void snack3()
{
    int somma = 0;
    Console.WriteLine("Inserisci per 10 volte un numero: ");
    for (int i = 0; i < 10; i++) 
    {
        int numeroUtente = Convert.ToInt32(Console.ReadLine());
        somma += numeroUtente;
    }
    Console.WriteLine("la somma dei numeri inseriti e {0}", somma);
}

void snack4()
{
    int somma = 0;
    var numbers = new int[10];

    for (int i = 2;i <= 10;i++) 
    {
         somma += i;
    }

    var media = somma / 9;
    Console.WriteLine("La somma dei numeri da 2 a 10 e {0}", somma);
    Console.WriteLine("La media dei numeri da 2 a 10 e {0}", media);
}