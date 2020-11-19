using System;

namespace Inlämning_1_Svante
{
    class Program
    {
        static void Main(string[] args)
        {
            char menySelectOne = 'G'; char menySelectTwo;
            double termOne; double termTwo; double termThree; double summa;

            while (menySelectOne == 'G' || menySelectOne == 'g') 
            {
                Console.WriteLine("\tMiniräknaren\n\tInstruktion: Du kommer få välja operator, operator, term, term, term för att sedan få ett resultat");
                Console.WriteLine("Var god skriv din första operator/räknesätt [+] [-] [*] [/]");

                Console.WriteLine("Mata in ditt första räknesätt/operator");
                String strOperatorOne = Console.ReadLine();
                menySelectOne = Convert.ToChar(strOperatorOne);

                Console.WriteLine("Mata in ditt andra räknesätt/operator");
                String strOperatortwo = Console.ReadLine();
                menySelectTwo = Convert.ToChar(strOperatortwo);

                Console.WriteLine("Mata in din första term/tal");
                string strTermOne = Console.ReadLine();
                termOne = Convert.ToDouble(strTermOne);

                Console.WriteLine("Mata in din första term/tal");
                string strTermTwo = Console.ReadLine();
                termTwo = Convert.ToDouble(strTermTwo);

                Console.WriteLine("Mata in din första term/tal");
                string strTermThree = Console.ReadLine();
                termThree = Convert.ToDouble(strTermThree);

               // gör nästlad if
                Console.WriteLine($"{termOne} + {termTwo} + {termThree} = {(termOne + termTwo + termThree)}");

                if (menySelectOne == '+')
                {
                    
                    if (menySelectTwo == '+')
                    {
                        summa = ((termOne + termTwo + termThree));
                    }
                }





            }
            

            

            /*Inlämningsuppgift 1
            Be användaren att ange ett par operatorer
            Be sedan användaren om ett par termer att använda operatorerna på
            Visa sen ekvationen och resultatet av beräkningen.
            Resultatet skall sen läggas till i en array
            Om summan är mindre än 100 skriv ut; ”Less then a hundred”
            Om summan är mer än 100 skriv ut; ”More then a hundred”
            Om summan är lika med 100 skriv ut; ”Cool, now you have a hundred, clap clap”
            Programmets titel i konsolen skall vara modifierat
            Programmet skall upprepa tills användaren själv väljer att avsluta
            Vid avslut skall summan av alla resultat skrivas ut
            Använd Git för att verisionshantera koden och ladda upp git-repot till din GitHub
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
