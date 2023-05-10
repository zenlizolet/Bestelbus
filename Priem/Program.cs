using System;

class Program
{
    static void Main(string[] args)
    {
        //lees wat de user heeft ingevoerd
        //n = aantal pakjes 
        // r = aantal ritten

        // Lees de eerste regel in
        string input = Console.ReadLine();

        // Split de input op spaties
        string[] inputArr = input.Split(' ');

        // Haal de waarden van n en r uit de input
        int n = int.Parse(inputArr[0]);
        int r = int.Parse(inputArr[1]);

        // Maak een nieuwe array voor de getallen
        int[] numbers = new int[n];

        // Loop over de rest van de input en voeg de getallen toe aan de numbers array
        int counter = 0;
        while (counter < n)
        {
            // Lees een nieuwe regel
            string line = Console.ReadLine();

            // Split de regel op spaties
            string[] lineArr = line.Split(' ');

            // Loop over de waarden in de regel en voeg ze toe aan de numbers array
            foreach (string s in lineArr)
            {
                numbers[counter] = int.Parse(s);
                counter++;

                // Als de counter gelijk is aan n, stop de loop
                if (counter == n)
                {
                    break;
                }
            }
        }

        // Test output
        Console.WriteLine($"n = {n}, r = {r}");
        Console.WriteLine($"numbers = [{string.Join(",", numbers)}]");
 
        // output = b = bus : int B = Console.WriteLine(getal);
        int totaalgewicht = 0;
        for (int i = 0; i < n; i++)
        {
            totaalgewicht += numbers[i];
            Console.WriteLine("totaalgewicht: " + totaalgewicht + " gewicht pakketje:" + numbers[i]);
        }
        Console.WriteLine("totaalgewicht: " + totaalgewicht);
        // bereken de minimale grootte van de bus bij géén volgorde
        int b = (int)(totaalgewicht / r); 

        //controlleer of er niet een pakketje toevallig groter is dan de basic buswaarde, zoja increase buswaarde naar het huidige (te zware) pakketje
        for (int i = 2; i <= n - 1; i++)
        {
            if (numbers[i]> b) { b = numbers[i]; }
        }




        
        int segment = b;
        int segmentcounter = 1;
        int huidige_pakketje = 0;
        int bussize = (int)b;
        Console.WriteLine("huidige pakketje: " + numbers[huidige_pakketje]);

        //maak segmenten, en houdt het aantal segmenten bij.
        
        /*while (huidige_pakketje <= 1 + n)
        {
            if (segment - numbers[huidige_pakketje] > 0)
            {
                segment -= numbers[huidige_pakketje];
                if (huidige_pakketje < n - 1) { huidige_pakketje++; } else { break; } ;
                Console.WriteLine("huidige pakketje: " + numbers[huidige_pakketje] + " segment: segment " + segmentcounter + " buswaarde: " + bussize);
            }
            else
            {
                segmentcounter++;
                segment = bussize;
            }
        }
        if (segmentcounter > r) { b++; }
        if(segmentcounter > r) { b--; }
        */
            




    }
}
