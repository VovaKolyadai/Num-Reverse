namespace NumReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse this num!");

            SafeParse("Enter  three unit numb to revrse it: ", out int parsedNumb);

            int revNumb = ReversNumber(parsedNumb);

            Console.WriteLine(revNumb);
        }

        static int ReversNumber(int num)
        {
            // if num = 321
            int hundredths = num / 100; // so, hundredths = 3
            int tens = (num / 10 - hundredths * 10) * 10; // so, tens = 2
            int units = num - (hundredths * 100 + tens); // so, units = 1

            return units * 100 + tens + hundredths;

        }

        static void SafeParse(string s, out int returnValue)
        {
            bool isSafe = false;
            do
            {
                Console.Write(s);
                isSafe = int.TryParse(Console.ReadLine(), out returnValue);   
            } while (!isSafe || !(returnValue < 1000));


        }
    }
}