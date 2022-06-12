using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace tModLoader_Mods_to_links
{
    internal class Request
    {
    public async static Task<string> RequestURl(string modname)
    {
        string url = $"http://javid.ddns.net/tModLoader/download.php?Down={modname}.tmod";
        string content = null;
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var responsestatuscode = (int)response.StatusCode;
        //string data = responsestatuscode.ToString();
        var responsestatuscode11 = response.RequestMessage;
            string data = responsestatuscode11.ToString();
            if (!data.Contains("javid.ddns"))
            {
                LinesAppend.LinesWrite(url);
            }
            return data;
    }
}
}
