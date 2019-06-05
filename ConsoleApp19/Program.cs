using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp19
{
    class ReadAndPrintFiles
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ancanica\Desktop\TAM";
            Console.ReadLine();

            try
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
           
            catch (PathTooLongException)
            {
                Console.WriteLine("The path exceed the maximum lenght.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file path is incorrect.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The format of the path is invalid.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
          
            catch (IOException)
            {
                Console.WriteLine("An I/O error occured.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have permission to access this file.");
            }
        }
    }
}
