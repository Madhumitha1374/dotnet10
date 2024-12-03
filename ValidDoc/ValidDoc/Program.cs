using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ValidDoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                string filePath = "D:\\DotNetWorking\\doc1.txt";

                // Define the expected format as an array of strings or a regex pattern, etc.
                string[] expectedFormat = {
                    "Header: *",
                    "Date: *",
                    "Name: *",
                    "Content: *"
                };

                // Read the file line by line
                string[] lines = File.ReadAllLines(filePath);
                bool isValid = true;

            // Verify each line against the expected format

            var result = from a in expectedFormat where a.StartsWith("h") select a ;
            bool r = expectedFormat.All(a => lines.Contains(a.Split(':')[0]+":"));
            if (r)
            {
                Console.WriteLine("The document is in expected format");
            }
            else 
            {
                Console.WriteLine("The document is not in expected format");
            }

                //for (int i = 0; i < expectedFormat.Length; i++)
                //{
                    
                //    if ( lines[i].StartsWith(expectedFormat[i].Split(':')[0] + ":"))
                //    {
                //    isValid = true;
                //    if(isValid == false)
                //    {
                //        break;
                //    }
                //    }
                //}

                //if (isValid)
                //{
                //    Console.WriteLine("The document is in the expected format.");
                //}
                //else
                //{
                //    Console.WriteLine("The document is NOT in the expected format.");
                //}
            Console.ReadLine();
            }
        
        }

    }
