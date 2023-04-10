using System;

class Masiivid
{
    static void Main(string[] args)
    {
        //1
        /*
        Random random = new Random();
        int N = random.Next(-100, 100);
        int M = random.Next(N, 100);

        if (N < 0)
        {
            N = Math.Abs(N);
        }
        if (M < 0)
        {
            M = Math.Abs(M);
        }

        int[] array = new int[Math.Abs(M - N) + 1];
        int sign = Math.Sign(M - N);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = N + i * sign;
            Console.WriteLine($"Ruudu arv {array[i]} on {array[i] * array[i]}");
        }
        */
        //2
        /*
        int[] numbrid = new int[6];

        // Küsige kasutajalt viis numbrit ja salvestage need massiivi
        for (int i = 1; i < numbrid.Length; i++)
        {
            Console.Write(i + " Sisestage number: ");
            numbrid[i] = int.Parse(Console.ReadLine());
        }

        // Arvutage arvude summa, aritmeetiline keskmine ja korrutis
        int sum = 0;
        double arkesk = 0;
        int korrutis = 1;

        foreach (int number in numbrid)
        {
            sum += number;
            korrutis *= number;
        }

        arkesk = (double)sum / numbrid.Length;
        double Arifkesk = Math.Round(arkesk, 2);

        // Sisestage arvude summa, aritmeetiline keskmine ja korrutis
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Aritmeetiline keskmine: " + Arifkesk);
        Console.WriteLine("Korrutis: " + korrutis);
        */
        //3
        /*
        string vastus;

        do
        {
            Console.Write("Kas tahad elevandi ära osta? ");
            vastus = Console.ReadLine();
        } 
        while (vastus.ToLower() != "elevant");

        Console.WriteLine("Suurepärane! Sa ostsid elevandi.");
        */
        //4
        /*
        Random rnd = new Random();
        int number = rnd.Next(1, 11); // Loo juhuslik arv vahemikus 1-10
        Console.WriteLine("Arva ära arv 1-10");
        for (int i = 1; i <= 5; i++)
        {
            int vastus = int.Parse(Console.ReadLine());
            if (vastus == number)
            {
                Console.WriteLine("Arvasid ära vastus"+i+" korrast");
            }
            else 
            {
                Console.WriteLine("Proovi veel");
            }
            
        }
        Console.WriteLine("Sa kaotasid! Arv oli "+ number);
        */
        //5
        /*
        int[] numbrid = new int[4];

        // Küsige kasutajalt neli numbrit ja salvestage need massiivi
        for (int i = 0; i < numbrid.Length; i++)
        {
            Console.Write($"Sisestage number {i + 1}: ");
            numbrid[i] = int.Parse(Console.ReadLine());
        }

        // Leidke nende nelja numbri seast suurim neljakohaline number
        Array.Sort(numbrid);
        int maxNum = numbrid[3] * 1000 + numbrid[2] * 100 + numbrid[1] * 10 + numbrid[0];

        // Kontrollige, kas suurim number on neljakohaline
        if (maxNum >= 1000 && maxNum <= 9999)
        {
            Console.WriteLine($"Suurim neljakohaline arv on {maxNum}.");
        }
        else
        {
            Console.WriteLine("Neljakohalise arvu ei tule.");
        }
        */      
        //6
        /*
        int[,] Korrutustabel = new int[10, 10];

        // Korrutustabeli massiivi asustamine
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Korrutustabel[i, j] = (i + 1) * (j + 1);
            }
        }

        // Väljund korrutustabelist
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(Korrutustabel[i, j] + "\t");
            }
            Console.WriteLine();

        }
        */
    }
}