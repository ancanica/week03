using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL of the file: ");
            string url = Console.ReadLine();
            Console.Write("Enter directory: ");
            string directory = Console.ReadLine();


            WebClient webClient = new WebClient();

            try
            {
                webClient.DownloadFile(url, directory);
                Console.WriteLine("Download complete!");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid address.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid address.");
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }
}

