using System;

public static class TwoFer
{
    public static string Name(string input = null)
    {
        input = (input == null) ? "you" : input;

        return String.Format("One for {0}, one for me.", input);
    }
}