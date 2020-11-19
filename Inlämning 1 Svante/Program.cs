using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlämning_1_Svante
{
    class Program
    {
        static void Main(string[] args)
        {
            char menySelectOne = 'G'; char menySelectTwo;
            double termOne; double termTwo; double termThree; double summa = 0;
            List<double> total = new List<double>();




            while (menySelectOne == 'G' || menySelectOne == 'g') 
            {
                
                Console.WriteLine("\tMiniräknaren\n\tInstruktion: Du kommer få välja operator, operator, term, term, term för att sedan få ett resultat");
                Console.WriteLine("Var god skriv din första operator/räknesätt [+] [-] [*] [/]");

                // lite lek med färger
                Console.WriteLine("Mata in ditt första räknesätt/operator");
                String strOperatorOne = Console.ReadLine();
                menySelectOne = Convert.ToChar(strOperatorOne);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"? {menySelectOne}");
                Console.ResetColor();

                Console.WriteLine("Mata in ditt andra räknesätt/operator");
                String strOperatortwo = Console.ReadLine();
                menySelectTwo = Convert.ToChar(strOperatortwo);                           
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"? {menySelectOne} ? {menySelectTwo}");
                Console.ResetColor();
                

                Console.WriteLine("Mata in din första term (tal)");
                string strTermOne = Console.ReadLine();
                termOne = Convert.ToDouble(strTermOne);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{termOne} {menySelectOne} ? {menySelectTwo}");
                Console.ResetColor();


                Console.WriteLine("Mata in din andra term (tal)");
                string strTermTwo = Console.ReadLine();
                termTwo = Convert.ToDouble(strTermTwo);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{termOne} {menySelectOne} {termTwo} {menySelectTwo}");
                Console.ResetColor();

                Console.WriteLine("Mata in din tredje term (tal)");
                string strTermThree = Console.ReadLine();
                termThree = Convert.ToDouble(strTermThree);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{termOne} {menySelectOne} {termTwo} {menySelectTwo} {termThree}");
                Console.ResetColor();

                // gör nästlad if


                if (menySelectOne == '+')
                {

                    if (menySelectTwo == '+')
                    {
                        summa = ((termOne + termTwo + termThree));
                        Console.WriteLine($"{termOne} + {termTwo} + {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '-')
                    {
                        summa = ((termOne + termTwo - termThree));
                        Console.WriteLine($"{termOne} + {termTwo} - {termThree} = {summa}");

                    }
                    else if (menySelectTwo == '*')
                    {
                        summa = ((termOne + termTwo) * (termThree));
                        Console.WriteLine($"{termOne} + {termTwo} * {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '/')
                    {
                        summa = ((termOne + termTwo) / (termThree));
                        Console.WriteLine($"{termOne} + {termTwo} / {termThree} = {summa}");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt värde på räknesätt 2");
                        menySelectOne = ('g');

                    }

                }
                else if (menySelectOne == '-')
                {
                    if (menySelectTwo == '+')
                    {
                        summa = ((termOne - termTwo + termThree));
                        Console.WriteLine($"{termOne} - {termTwo} + {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '-')
                    {
                        summa = ((termOne - termTwo - termThree));
                        Console.WriteLine($"{termOne} - {termTwo} - {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '*')
                    {
                        summa = ((termOne - termTwo) * (termThree));
                        Console.WriteLine($"{termOne} - {termTwo} * {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '/')
                    {
                        summa = ((termOne - termTwo) / (termThree));
                        Console.WriteLine($"{termOne} - {termTwo} / {termThree} = {summa}");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt värde på räknesätt 2");
                        menySelectOne = ('g');
                    }

                }
                else if (menySelectOne == '*')
                {
                    if (menySelectTwo == '+')
                    {
                        summa = ((termOne * termTwo) + (termThree));
                        Console.WriteLine($"{termOne} * {termTwo} + {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '-')
                    {
                        summa = ((termOne * termTwo) - (termThree));
                        Console.WriteLine($"{termOne} * {termTwo} - {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '*')
                    {
                        summa = ((termOne * termTwo) * (termThree));
                        Console.WriteLine($"{termOne} * {termTwo} * {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '/')
                    {
                        summa = ((termOne * termTwo) / (termThree));
                        Console.WriteLine($"{termOne} * {termTwo} / {termThree} = {summa}");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt värde på räknesätt 2");
                        menySelectOne = ('g');
                    }
                }
                else if (menySelectOne == '/')
                {
                    if (menySelectTwo == '+')
                    {
                        summa = ((termOne / termTwo) + (termThree));
                        Console.WriteLine($"{termOne} / {termTwo} + {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '-')
                    {
                        summa = ((termOne / termTwo) - (termThree));
                        Console.WriteLine($"{termOne} / {termTwo} - {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '*')
                    {
                        summa = ((termOne / termTwo) * (termThree));
                        Console.WriteLine($"{termOne} / {termTwo} * {termThree} = {summa}");
                    }
                    else if (menySelectTwo == '/')
                    {
                        summa = ((termOne / termTwo) / (termThree));
                        Console.WriteLine($"{termOne} / {termTwo} / {termThree} = {summa}");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt värde på räknesätt 2");
                        menySelectOne = ('g');
                    }
                }
                else 
                {
                    Console.WriteLine("Ogiltigt värde på räknesätt 1");
                    menySelectOne = ('g');
                }

                // addera summa till array
                
                if (summa < 100)
                {
                    Console.WriteLine("Värdet är mindre än hundra!");
                }
                else if (summa > 100)
                {
                    Console.WriteLine("Värdet är mindre än hundra!");
                }
                else if (summa == 100)
                {
                    Console.WriteLine("Väldigt tufft, värdet är hundra!");
                }
                // addera summa till array
                total.Add(summa);
               
                Console.WriteLine($"vill du köra igen tryck [G]\n Vill du avsluta tryck [Q]");
                strOperatorOne = Console.ReadLine();
                menySelectOne = Convert.ToChar(strOperatorOne);

            }
            Console.WriteLine(total.Sum());
            Console.WriteLine("Antal försök " + (total.Count + +1));

            // skriv ut totalen och säg hejdå
            //Console.WriteLine($"totalen av dina uräkningar är {total.GetValue}");



            /*Inlämningsuppgift 1
            Be användaren att ange ett par operatorer [x]
            Be sedan användaren om ett par termer att använda operatorerna på [x]
            Visa sen ekvationen och resultatet av beräkningen. [x]
            Resultatet skall sen läggas till i en array
            Om summan är mindre än 100 skriv ut; ”Less then a hundred”[x]
            Om summan är mer än 100 skriv ut; ”More then a hundred”[x]
            Om summan är lika med 100 skriv ut; ”Cool, now you have a hundred, clap clap”[x]
            Programmets titel i konsolen skall vara modifierat https://www.geeksforgeeks.org/c-sharp-how-to-change-title-of-the-console/
            Programmet skall upprepa tills användaren själv väljer att avsluta
            Vid avslut skall summan av alla resultat skrivas ut
            Använd Git för att verisionshantera koden och ladda upp git-repot till din GitHub [x]
            
            Programmet måste inte vara felfritt eller buggfritt. Framför allt är det verisionshanteringen som testas. Om två operatorer är för svårt, börja med en och sen lägg på fler om du kan.
            Exempel: 
            (‘>’ or ‘$’ används ofta för att notera att något händer i en kommandotolk)
            > Enter first operator: x
            > Enter second operator: -
            > Enter first term: 8 
            > Enter second term: 6 
            > Enter third term: 3 
            > 8 x 6 – 3 = 45
            > ”The sum is less then a hundred”
            > Another try?
            > Thank you for playing. The sum of all round is 221. Bye

            Deadline för denna uppgift är 30/11 */
        }
    }
}
