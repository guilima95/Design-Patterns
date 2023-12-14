namespace Adapter;

// Client:
// collaborates with objects conforming to the Target interface.

public class ClientService(ILogger logger)
{
    private readonly ILogger _logger = logger;

    public void AddClient()
    {
        _logger.Log("Client created successfuly");
    }
}