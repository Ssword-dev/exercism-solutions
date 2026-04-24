using PythagoreanTriple = (int a, int b, int c);

public static class PythagoreanTriplet
{
    public static IEnumerable<PythagoreanTriple> TripletsWithSum(int sum)
    {
        List<PythagoreanTriple> triples = [];
        
        var validRangeForA = sum / 3; // floors
        var validRangeForB = sum / 2;
        for (int a = 1; a <= validRangeForA; a++) {
            for (int b = a; b <= validRangeForB; b++) {
                // a^2 + b^2 = c^2
                // c^2 = a^2 + b^2
                // c = sqrt(a^2 + b^2)
                var cSquared = (a * a) + (b * b);
                var c = (int)Math.Sqrt(cSquared);

                // checks if `c` is an integer, meaning perfect square.
                if ((c * c) != cSquared) continue;

                // c is only valid it satisfies the conditions:
                // a < c AND b < c
                // but a <= b, therefore if b < c,
                // then a < c
                // so we only need to check b < c.
                // so it is invalid if c <= b.
                if (c <= b) continue;

                // triples such that their sum is equal to the target sum.
                if ((a+b+c) != sum) continue;

                triples.Add((PythagoreanTriple)(a, b, c));
            }
        } 

        return triples;
    }
}