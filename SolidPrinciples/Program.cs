using SolidPrinciples.SRP;

internal class Program
{
    private static void Main(string[] args)
    {
        // #1: SRP

        SingleResponsibilityPrinciple singleResponsibilityPrinciple = new SingleResponsibilityPrinciple();
        singleResponsibilityPrinciple.ExecuteSRP();


        // #2: 

        Console.ReadLine();
        
    }
}