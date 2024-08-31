namespace Hostkey.SDK;

public class HostkeyClientOptions
{
    public const string BaseUrl = "https://invapi.hostkey.ru";

    private string ApiKey { get; set; }

    public HostkeyClientOptions(string apiKey)
    {
        ApiKey = apiKey;
    }
}