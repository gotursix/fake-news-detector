using System;

namespace WebParser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Website web = new InfoWarsParser("https://www.infowars.com/posts/tucker-carlson-inflation-much-worse-than-what-economically-illiterate-leaders-are-saying/");
            Console.WriteLine(web.Content);
        }
    }
}
