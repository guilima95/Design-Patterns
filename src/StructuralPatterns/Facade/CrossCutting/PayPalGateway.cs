
namespace Facade.CrossCutting;

public class PayPalGateway : IPayPalGateway
{
    public async Task<bool> CommitTransactionAsync(string cardHashKey, Guid orderId, decimal amount)
    {
        return await Task.FromResult(new Random().Next(2) == 0);
    }

    public async Task<string> GetCardHashKeyAsync(string serviceKey, string creditCard)
    {
        string hash = new(Enumerable
            .Repeat("ABCDEFGHIJKELMNOPQRSTUVXYZ012345678910", 10)
            .Select(s => s[new Random().Next(s.Length)])
            .ToArray());

        return await Task.FromResult(hash);
    }

    public async Task<string> GetPayPalServiceKeyAsync(string apiKey, string encriptionKey)
    {
        string key = new(Enumerable
           .Repeat("ABCDEFGHIJKELMNOPQRSTUVXYZ012345678910", 10)
           .Select(s => s[new Random().Next(s.Length)])
           .ToArray());

        return await Task.FromResult(key);
    }
}
