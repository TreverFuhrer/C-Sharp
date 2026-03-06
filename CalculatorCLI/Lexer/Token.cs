
public class Token
{
    TokenType type;
    string text;
    double value;

    public Token(TokenType type, string text, double value)
    {
        this.type = type;
        this.text = text;
        this.value = value;
    }
}