namespace StringReverser;
class Program
{
    static void Main(string[] args)
    {
        var shouldContinue = "y";
        var manipulator = new StringManipulator();

        while (shouldContinue != "n")
        {
            Console.WriteLine("Enter a sentense/string.\n");
            var sentence = Console.ReadLine();

            var result = !string.IsNullOrEmpty(sentence) ? manipulator.ReverseString(sentence) : "You did not type your string.";
            Console.WriteLine(string.Concat("\n", result, "\n"));

            Console.WriteLine("To continue press any key and to exit press n...");
            shouldContinue = Console.ReadLine();
        }
        Console.WriteLine("\nGoodbye...");
    }
}

class StringManipulator
{
    public string ReverseString(string sentence)
    {
        var words = sentence.Split(' ');
        Array.Reverse(words);

        return string.Join(" ", words);
    }
}
