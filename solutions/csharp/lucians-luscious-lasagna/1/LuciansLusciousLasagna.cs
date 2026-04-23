class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutesCookingInTheOven) {
        return ExpectedMinutesInOven() - minutesCookingInTheOven;
    }

    public int PreparationTimeInMinutes(int numberOfLayersAdded)
    {
        return numberOfLayersAdded * 2;
    }

    public int ElapsedTimeInMinutes(int numberOfLayersAdded, int minutesCookingInTheOven)
    {
        return PreparationTimeInMinutes(numberOfLayersAdded) + minutesCookingInTheOven;
    }
}
