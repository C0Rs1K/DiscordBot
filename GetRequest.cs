
using System.Net;

namespace DiscordBot;
public class GetRequest
{
    public string? Response { get; private set; }
    HttpWebRequest? _request;
    string _address;

    public GetRequest(string address)
    {
        _address = address;
    }

    public void Run()
    {
        _request = (HttpWebRequest)WebRequest.Create(_address);
        _request.Method = "Get";

        var response = (HttpWebResponse)_request.GetResponse();
        var stream = response.GetResponseStream();

        if (stream != null)
        {
            Response = new StreamReader(stream).ReadToEnd();
        }
    }

}