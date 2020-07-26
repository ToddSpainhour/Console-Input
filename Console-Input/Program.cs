using System;

namespace Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today we are going to learn about the ways you can accept user input inside the command line.");
            Console.WriteLine(" ");

            Console.WriteLine("Let's start by learning about Console.Read()");
            Console.WriteLine(" ");

            Console.WriteLine("Every key on your keyboard has a corresponding number code known as the numeric ASCII value. Console.Read() detects and returns that value after a single keystroke.");
            Console.WriteLine("Some conversion in needed to display the key instead of this code. I've used the \"Convert.ToChar()\" for this one.");
            Console.WriteLine("Let's see it in action. Press any key on your keyboard then hit \"Enter\" ");
            Console.WriteLine(" ");

            var userSelectedKey = Console.Read();
            var userSelectedKeyConvertedToChar = Convert.ToChar(userSelectedKey);
            Console.WriteLine($"You selected {userSelectedKeyConvertedToChar} which is the numeric ASII value of {userSelectedKey}");
            Console.WriteLine(" ");

            Console.WriteLine("Press any key to continue");          
            var pressedKeytoAdvance = Console.ReadKey();
            Console.WriteLine(" ");


            Console.WriteLine("Now let's discuss the Console.ReadKey() method.");
            Console.WriteLine(" ");

            Console.WriteLine("The Console.ReadKey() method also only accepts one input but is a little different.");
            Console.WriteLine("Instead of returning a ASCII value, it returns a \"ConsoleKeyInfo\" obejct which also needs some conversion to get what we are looking for. We will see that next.");
            Console.WriteLine("Press another key on your keyboard.");
            Console.WriteLine(" ");


            var myEnteredKey = Console.ReadKey(true);
            Console.WriteLine($" Great choice. Without any conversion, you get \"{myEnteredKey}\" which doesn't make much sense without adding some methods to this value. When we add the \"myEnteredKey.Key\" property, we get {myEnteredKey.Key}. Tack on the \"myEnteredKey.Key.ToString()\" and we get {myEnteredKey.Key.ToString()}.");
            Console.WriteLine(" ");

            Console.WriteLine("Press any key to continue and press escape when you're done.");
            Console.WriteLine(" ");

            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey(true);
                Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key. Keep trying new keys or press \"Escape\" to move on.");

            } while (enteredKey.Key != ConsoleKey.Escape);


            string usersSentence;

            Console.WriteLine(" ");
            Console.WriteLine("Awesome. Now let's discuss Console.ReadLine()");
            Console.WriteLine("This method lets the user type whole lines of characters, and there's no conversion needed.");
            Console.WriteLine("Type a whole sentence and press \"Enter\" when you're done.");
            usersSentence = Console.ReadLine();


            do
            {
                Console.WriteLine(" ");
                usersSentence = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine($"Wow. Great writing. You wrote: {usersSentence}");
                Console.Write("Keep on writing or exit by typing \"quit\" ");

            } while (usersSentence != "quit");

            Console.WriteLine(" ");
            Console.WriteLine("That's it! You just learned about the three ways to accept user input when working in the command line.");
            Console.WriteLine("You'll use Console.Read(), Console.ReadKey(), and Console.ReadLine() often if you continue making console apps!");
            Console.Read();
        }
    }
}
