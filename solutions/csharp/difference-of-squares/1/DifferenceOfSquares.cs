public static class DifferenceOfSquares
{
    public static int GaussSum(int max) => max * (max + 1) / 2;
    public static float SumOfSquaresFactor(int max) => (float)((2 * max)+1)/3;
    
    public static int CalculateSquareOfSum(int max)
    {
        var sum = GaussSum(max);
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        return (int)(GaussSum(max) * SumOfSquaresFactor(max));
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}