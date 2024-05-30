namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Are you a he or a she?");
            string userIdentity = Console.ReadLine();

            Console.WriteLine("Do you like to walking or running?");
            string userExercise = Console.ReadLine();

            Console.WriteLine("What is your favorite type of pizza?");
            string favoritePizza = Console.ReadLine();

            Console.WriteLine("What is your favorite book to read?");
            string favoriteBook = Console.ReadLine();


            Console.Write($"While {userExercise} through the park, {userName} saw a squirrel struggling to carry a slice of {favoritePizza} pizza that was twice its size.");
            Console.Write($"Amused, {userIdentity} watched the squirrel drag the pizza up a tree, only for it to fall back down. The squirrel didn't give up.");
            Console.Write($"It ran down, grabbed the pizza, and tried again. This happened several times until the squirrel finally managed to sit with its prize.");
            Console.Write($"Just then, a crow swooped downed down and snatched the pizza away. {userName} couldn't help but laugh at the squirrel's confused expression.");
            Console.Write($"{userIdentity} went to take a rest, read her favorite book called {favoriteBook} on her phone, and enjoyed the peaceful ambiance of the park.");
        }
    }
}
