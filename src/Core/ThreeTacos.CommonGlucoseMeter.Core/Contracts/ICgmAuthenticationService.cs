namespace ThreeTacos.CommonGlucoseMeter.Core.Contracts;

public interface ICgmAuthenticationService
{
    Task AuthenticateAsync();
    Task AuthenticateAsync(string username, string password);
    Task AuthorizeAsync();
    Task GetAuthorizationTokenAsync();
}