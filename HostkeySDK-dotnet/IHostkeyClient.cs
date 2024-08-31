using Hostkey.SDK.Types.Enum;

namespace Hostkey.SDK;

/// <summary>
/// Hostkey API client
/// </summary>
public interface IHostkeyClient
{ 
    Task Auth(AuthAction action);
}