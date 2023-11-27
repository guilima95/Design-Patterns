namespace Adapter;

// Client:
// collaborates with objects conforming to the Target interface.

public class ClientService
{
    private readonly ILogger _logger;

    public ClientService(ILogger logger)
    {
        _logger = logger;
    }

    public void AddClient()
    {
        _logger.Log("Client created successfuly");
    }
}