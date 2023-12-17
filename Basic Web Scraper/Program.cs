using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Web_Scraper
{
    class Program
    {
        static async Task Main()
        {
            string url = "https://www.example.com"; // Replace with the URL of the website you want to scrape

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string htmlContent = await client.GetStringAsync(url);

                    HtmlDocument document = new HtmlDocument();
                    document.LoadHtml(htmlContent);

                    // Use XPath or other methods to select and extract the desired information
                    var titles = document.DocumentNode.SelectNodes("//h2[@class='article-title']");

                    if (titles != null)
                    {
                        foreach (var title in titles)
                        {
                            Console.WriteLine(title.InnerText.Trim());
                        }
                    }
                    else
                    {
                        Console.WriteLine("No titles found on the page.");
                    }
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Error fetching website content. Check your internet connection.");
                }
            }

        }
    }
}
