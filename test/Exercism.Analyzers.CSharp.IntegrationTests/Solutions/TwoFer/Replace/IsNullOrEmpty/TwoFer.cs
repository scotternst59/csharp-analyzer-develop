using System;

public static class TwoFer
{
    public static string Speak(string input = null)
    {
        string twofer = "One for you, one for me.";

        if (string.IsNullOrEmpty(input))
        {
            twofer = twofer.Replace("you", input);
        }

        return twofer;
    }
}
