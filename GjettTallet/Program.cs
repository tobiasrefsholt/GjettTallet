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
                string message = (inputNum < randomNum) ? "For lavt, prøv igjen!" : "For høyt, prøv igjen!";
                Console.WriteLine(message);
                inputNum = Convert.ToInt32(Console.ReadLine());
            }
            if (inputNum == randomNum) {
                Console.WriteLine("Du gjettet riktig!");
            }
        }
    }
}