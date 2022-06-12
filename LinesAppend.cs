using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tModLoader_Mods_to_links
{
    internal class LinesAppend
    {
        public static string LinesWrite(string LineWrite)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            File.AppendAllText(@$"{CurrentDirectory}\\ModsUrls.txt", LineWrite + Environment.NewLine);
            string result = "Mod has been registered";
            return result;
        }
    }
}
