public static class LineUp
{
    public static string Format(string name, int number)
    {
        return $"{name}, you are the {number}{OrdinalNumeralSuffix(number)} customer we serve today. Thank you!";
    }

    public static string OrdinalNumeralSuffix(int number) {
        var stringifiedNumber = number.ToString();
        var lastDigit = stringifiedNumber[stringifiedNumber.Length - 1];
        char? secondToTheLastDigit = number > 9 ? stringifiedNumber[stringifiedNumber.Length - 2] : null;
        if (secondToTheLastDigit == '1') {
            return "th";
        }

        switch (lastDigit) {
            case '1':
                return "st";
            case '2':
                return "nd";
            case '3':
                return "rd";
            default:
                return "th";
        }
    }
}
