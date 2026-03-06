public class Lexer
{
    private string expression;

    public Lexer(string expression)
    {
        this.expression = expression;
    }

    public List<Token> Tokenize()
    {
        List<Token> tokens = [];

        for (int i = 0; i < expression.Length; ++i)
        {
            TokenType tokenType;
            
        }

        return tokens;
    }
}