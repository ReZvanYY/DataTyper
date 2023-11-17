namespace Datatyper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(numberFive());
            Console.WriteLine(Hello());
            Console.WriteLine(Decimal1());
            Console.WriteLine(Decimal2());
            Console.WriteLine(Decimal3());
            Console.WriteLine(AForEffort());
            Console.WriteLine(TrueOrFalse());
            Console.WriteLine(NumberOverTwoBillion());

            Console.WriteLine(numberFive() + Decimal3());
            Console.WriteLine(returnNada());
        }
        static int numberFive()
        {
            int number = 5;
            return number;
        }
        static string Hello()
        {
            string hi = "Halla";
            return hi;
        }
        static float Decimal1()
        {
            float deci1 = 0.3255f;
            return deci1;
        }
        static double Decimal2()
        {
            double deci2 = 0.23;
            return deci2;
        }
        static decimal Decimal3()
        {
            decimal deci3 = 0.3255m;
            return deci3;
        }
        static char AForEffort()
        {
            char bravo = 'a';
            return bravo;
        }
        static bool TrueOrFalse()
        {
            bool TrueDat = true;
            return TrueDat;
        }
        static long NumberOverTwoBillion()
        {
            long bigNumber = 2000000001;
            return bigNumber;
        }
        static string returnNada()
        {
            string returnNothing = "Denne metoden returnerer ingenting";
            return returnNothing;
        }
    }


}
//int tall = 1;

//float desimaltall1 = 1.0f; // aprox
//double desimaltall2 = 1.0;
//decimal desimaltall3 = 1.01m; //Nøyaktig

//char bokstav = 'a';
//string tekst = "hello";

//bool trueOrFalse = false; // or true

//int[] tallAarray = { 1, 2, 3 };
//string[] tekstAarray = { "hello", "beautiful" };

//List<int> listemedtall = new List<int>(); //lager en ny liste med tall.
//List<string> listemedtekst = new List<string>(); //lager en ny liste med tekst.
//List<char> listemed = new List<char>(); // lager en ny liste med bokstaver.