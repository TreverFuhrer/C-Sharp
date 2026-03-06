

class Program
{
    static void Main(string[] args)
    {
        string input = "12 + 3 * (4 - 1)";
        Lexer lexer = new Lexer(input);
        List<Token> tokens = lexer.Tokenize();

        foreach (Token token in tokens)
        {
            Console.WriteLine(token);
}
    }
}