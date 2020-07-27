using Newtonsoft.Json.Linq;
using System;
using System.IO.Pipes;
using System.Net.Http;

namespace WhenTwoTalk
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool toDO = true;
            do
            {
                QuoteGenerater.KanyeQuote();
                QuoteGenerater.RonQuote();
                Console.WriteLine("Keep The Convo going?  Y/N");
                var ans = Console.ReadLine();
                var answer = ans.ToLower();
                if (answer == "y")
                {
                    toDO = true;
                }
                else { toDO = false; }
            } while (toDO == true);

              
        }
    }
}
