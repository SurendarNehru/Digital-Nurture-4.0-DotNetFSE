using System;
class FinancialForecast
{
    public static double CalculateFutureValue(double initialamount, double annualrate, int totalyears)
    {
        if (totalyears == 0)
            return initialamount;
        return (1 + annualrate) * CalculateFutureValue(initialamount, annualrate, totalyears - 1);
    }
    public static void Main(string[] args)
    {
        double initialinvestment = 2500;
        double annualgrowthrate = 0.5;
        int forecastyear = 7;

        double projectedValue = CalculateFutureValue(initialinvestment, annualgrowthrate, forecastyear);
        Console.WriteLine("Predicted Future Value after " + forecastyear + " years: ₹" + Math.Round(projectedValue, 2));
    }
}
