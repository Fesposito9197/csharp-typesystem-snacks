
//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
//snack6();
//snack7();
//snack8();
//snack9();
//snack10();
//snack11();
//snack12();

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
    

    for (int i = 2;i <= 10;i++) 
    {
         somma += i;
    }

    var media = somma / 9;
    Console.WriteLine("La somma dei numeri da 2 a 10 e {0}", somma);
    Console.WriteLine("La media dei numeri da 2 a 10 e {0}", media);
}

void snack5()
{
    Console.WriteLine("Inserisci un numero: ");
    int numeroUtente = Convert.ToInt32(Console.ReadLine());

    if (numeroUtente % 2 == 0)
    {
        Console.WriteLine("Hai inserito un numero pari {0}", numeroUtente);
    }
    else
    {
        Console.WriteLine(numeroUtente + 1);
    }

}

void snack6()
{
    var invitati = new string[] { "Paolo", "Luca", "Giovanni", "Marco" };

    Console.WriteLine("Inserisci il tuo nome");
    var nomeUtente = Console.ReadLine();
    if (invitati.Contains(nomeUtente, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("Puoi entrare alla festa");
    }
    else
    {
        Console.WriteLine("Non puoi entrare alla festa");
    }
}

void snack7()
{
    var numeriInseriti = new int[6];
    Console.WriteLine("Inserisci per 6 volte un numero: ");
    for (int i = 0; i < 6; i++)
    {
        var numeroUtente = Convert.ToInt32(Console.ReadLine());
        if (numeroUtente % 2 != 0)
        {
            numeriInseriti[i] = numeroUtente;
            
        }
        else
        {
            Console.WriteLine("Inserisci un numero dispari");
        }

    }
    Console.WriteLine("Numeri dispari inseriti nell'array");

    for (int i = 0;i < numeriInseriti.Length; i++)
    {
        Console.WriteLine(numeriInseriti[i]);

    }
}

void snack8()
{
    int[] numbers = { 2, 4, 5, 7, 1, 8, 9, 10, 6, 3 };
    int somma = 0;
    Console.WriteLine("Gli elementi in posizione dispari sono");
    for (int i = 1;  i < numbers.Length; i+=2) 
    {
        Console.WriteLine($"{ numbers[i]}, ");
        somma += numbers[i];
    }
    Console.WriteLine("La loro somma e {0}", somma);
}

void snack9()
{
    

    //creo un array vuoto
    var numbers = new int[0];

    int somma = 0;
    while (somma < 50)
    {
        //chiedo di inserire i numeri a l'utente
        Console.WriteLine("Inserisci dei numeri");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if(userNumber <= 0)
        {
            Console.WriteLine("Non puoi inserire numeri negativi e lo 0");
            continue;
        }
        somma += userNumber;
    }
    Console.WriteLine("La somma degli elementi e < 50");
    
    for(int i = 1;i < numbers.Length; i++)
    {
        Console.WriteLine("I numeri inseriti sono:");
        Console.WriteLine(numbers[i]);
    }
}

void snack10()
{
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();

    for (int i = 0; i < N; i++)
    {
        var ints = new int[10];

        for (int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }

        foreach (var num in ints)
        {
            Console.Write($"{num}; ");
        }

        Console.WriteLine();
    }
}

void snack11()
{
    Console.WriteLine("Inserisci la prima parola:");
    string word1 = Console.ReadLine() ?? "";

    Console.WriteLine("Inserisci la seconda parola:");
    string word2 = Console.ReadLine()?? "";

    if (word1.Length == word2.Length)
    {
        Console.WriteLine("Le due parole hanno la stessa lunghezza:");
        Console.WriteLine(word1);
        Console.WriteLine(word2);
    }
    else if (word1.Length > word2.Length)
    {
        Console.WriteLine("La parola più lunga è:");
        Console.WriteLine(word1);
    }
    else
    {
        Console.WriteLine("La parola più lunga è:");
        Console.WriteLine(word2);
    }
}

void snack12()
{
    Console.WriteLine("Inserisci un numero:");
    int userNumber = Convert.ToInt32(Console.ReadLine());   

    if (userNumber % 2 == 0)
    {
        Console.WriteLine("il numero inserito e pari");
    }
    else
    {
        Console.WriteLine("il numero inserito e dispari");
    }
}