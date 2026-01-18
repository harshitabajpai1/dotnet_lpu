//Cunstruction
using System;

//exception class
class ConstructionEstimateException : Exception
{
    public ConstructionEstimateException(string message) : base(message)
    {
    }
}


class EstimateDetails
{
    public float ConstructionArea { get; set; }
    public float SiteArea { get; set; }
}

class Program
{
    public static EstimateDetails ValidateConstructionEstimate(float constructionArea, float siteArea)
    {
        if (constructionArea <= siteArea)
        {
            EstimateDetails details = new EstimateDetails();
			
            details.ConstructionArea = constructionArea;
            details.SiteArea = siteArea;
            return details;
        }
        else
        {
            throw new ConstructionEstimateException(
                "Sorry your Construction Estimate is not approved"
            );
        }
    }

    static void Main(string[] args)
    {
        try
        {
            float constructionArea = float.Parse(Console.ReadLine());
            float siteArea = float.Parse(Console.ReadLine());

            EstimateDetails result =
                ValidateConstructionEstimate(constructionArea, siteArea);

            Console.WriteLine("Construction Area: " + result.ConstructionArea);
            Console.WriteLine("Site Area: " + result.SiteArea);
        }
        catch (ConstructionEstimateException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
