using Hostkey.SDK.Types.Enum;

namespace Hostkey.SDK;

public class HostkeyClient : IHostkeyClient
{
    private readonly HostkeyClientOptions _options;

    public HostkeyClient(HostkeyClientOptions options)
    {
        _options = options;
    }

    public Task Auth(AuthAction action)
    {
        throw new NotImplementedException();
    }
}