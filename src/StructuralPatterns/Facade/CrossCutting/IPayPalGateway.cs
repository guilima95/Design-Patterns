namespace Facade.CrossCutting;

public interface IPayPalGateway
{
    Task<bool> CommitTransactionAsync(string cardHashKey, Guid orderId, decimal value);

    Task<string> GetCardHashKeyAsync(string serviceKey, string creditCard);

    Task<string> GetPayPalServiceKeyAsync(string apiKey, string encriptionKey);
}
