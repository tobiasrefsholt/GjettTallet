namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv ett tall mellom 0 og 100:");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int randomNum = rand.Next(0,100);
            while (inputNum != randomNum) {
                if (inputNum < randomNum) {
                    Console.WriteLine("For lavt, prøv igjen!");
                } else if (inputNum > randomNum) {
                    Console.WriteLine("For høyt, prøv igjen!");
                }
                inputNum = Convert.ToInt32(Console.ReadLine());
            }
            if (inputNum == randomNum) {
                Console.WriteLine("Du gjettet riktig!");
            }
        }
    }
}