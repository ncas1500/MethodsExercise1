namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string username = Console.ReadLine();

            Console.WriteLine("are you a he or a she?");
            string useridentity = Console.ReadLine();

            Console.WriteLine("do you like to walking or running?");
            string userexercise = Console.ReadLine();

            Console.WriteLine("what is your favorite type of pizza?");
            string favoritepizza = Console.ReadLine();

            Console.WriteLine("what is your favorite book to read?");
            string favoritebook = Console.ReadLine();


            Console.Write($"while {userexercise} through the park, {username} saw a squirrel struggling to carry a slice of {favoritepizza} pizza that was twice its size.");
            Console.Write($"Amused, {useridentity} watched the squirrel drag the pizza up a tree, only for it to fall back down. the squirrel didn't give up.");
            Console.Write($"It ran down, grabbed the pizza, and tried again. this happened several times until the squirrel finally managed to sit with its prize.");
            Console.Write($"Just then, a crow swooped downed down and snatched the pizza away. {username} couldn't help but laugh at the squirrel's confused expression.");
            Console.Write($"{useridentity} went to take a rest, read her favorite book called {favoritebook} on her phone, and enjoyed the peaceful ambiance of the park.");


            Console.WriteLine("Give me a number to add?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to add?");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number to multiply?");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to multiply?");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }

        public static int Sum(int num1, int num2)
        {

            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;

        }
    }
}
