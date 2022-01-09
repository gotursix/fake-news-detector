using System;

namespace WebParser
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Website web = new InfoWarsParser("https://www.infowars.com/posts/damage-control-reuters-ap-proclaim-no-evidence-of-mass-formation-psychosis/");
            Console.WriteLine(web.Content);
        }
    }
}
