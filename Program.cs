using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tModLoader_Mods_to_links
    
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        {
            /*
            var CurrentDirectory = Directory.GetCurrentDirectory();

            if (File.Exists($"{CurrentDirectory}\\ModsUrls.txt"))
            {
                File.Delete($"{CurrentDirectory}\\ModsUrls.txt");
                Console.WriteLine("cleared old mods url successful.");
            }
            */
            string modname = Console.ReadLine();
            var resault00 = await Request.RequestURl(modname);
            var resault000 = resault00.ToString();
            if (resault000.Contains("javid.ddns"))
            {
                string modnameplusNewchar = "t" + modname;
                var resaultFinal = await Request.RequestURl(modnameplusNewchar);
                var resaultFinal0 = resaultFinal.ToString();
                if (!resaultFinal0.Contains("javid.ddns"))
                {
                    Console.WriteLine("work");
                }
                else if (resaultFinal0.Contains("javid.ddns"))
                {
                    Console.WriteLine("not work");
                }
            }
            
            else if (!resault000.Contains("javid.ddns"))
            {
                Console.WriteLine("test00");
            }
            
            await Main(args);
            Console.ReadKey();
            
        }
    }
}
