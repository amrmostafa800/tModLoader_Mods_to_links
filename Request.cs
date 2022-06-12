using System.Net.Http;
using System.Threading.Tasks;


namespace tModLoader_Mods_to_links
{
    internal class Request
    {
    public async static Task<string> RequestURl(string modname)
    {
        string url = $"http://javid.ddns.net/tModLoader/download.php?Down={modname}.tmod";
        
        var client = new HttpClient();
        var result = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));
        var result0 = result.ToString();
            
        if (result0.Contains("application/octet-stream"))
        {
                LinesAppend.LinesWrite(url);
        }
            
        return result0;
    }
}
}
