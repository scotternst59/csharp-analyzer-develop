using System;

public static class TwoFer
{
    public static string Name(string input = null)
    {
        string twofer = "One for you, one for me.";

        if (string.IsNullOrWhiteSpace(input))
        {
            twofer = twofer.Replace("you", input);
        }

        return twofer;
    }
}
